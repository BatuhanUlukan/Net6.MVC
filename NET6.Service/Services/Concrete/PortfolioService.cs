using AutoMapper;
using ImageProcessor.Imaging.Colors;
using Microsoft.AspNetCore.Http;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Portfolios;
using NET6.Entity.Entities;
using NET6.Entity.Enums;
using NET6.Service.Extensions;
using NET6.Service.Helpers.Images;
using NET6.Service.Services.Abstractions;
using System.Security.Claims;


namespace NET6.Service.Services.Concrete
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public PortfolioService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            this.imageHelper = imageHelper;
        }
        public async Task<PortfolioListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var portfolios = categoryId == null
                ? await unitOfWork.GetRepository<Portfolio>().GetAllAsync(a => !a.IsDeleted, a => a.Category, i => i.Image, u => u.User)
                : await unitOfWork.GetRepository<Portfolio>().GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted, a => a.Category, i => i.Image, u => u.User);
            var sortedPortfolios = isAscending
                ? portfolios.OrderBy(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : portfolios.OrderByDescending(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new PortfolioListDto
            {
                Portfolios = sortedPortfolios,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = portfolios.Count,
                IsAscending = isAscending
            };
        }
        public async Task CreatePortfolioAsync(PortfolioAddDto portfolioAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var imageUpload = await imageHelper.Upload(portfolioAddDto.Title, portfolioAddDto.Photo, ImageType.Work);
            Image image = new(imageUpload.FullName, portfolioAddDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Image>().AddAsync(image);

            var portfolio = new Portfolio(portfolioAddDto.Title, portfolioAddDto.Content, userId, userEmail, portfolioAddDto.CategoryId, image.Id, portfolioAddDto.SeoId,portfolioAddDto.LinkId);

            await unitOfWork.GetRepository<Portfolio>().AddAsync(portfolio);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<PortfolioDto>> GetAllPortfoliosWithCategoryNonDeletedAsync()
        {

            var portfolios = await unitOfWork.GetRepository<Portfolio>().GetAllAsync(x => !x.IsDeleted, s => s.Seo, x => x.Category,l=>l.Link);
            var map = mapper.Map<List<PortfolioDto>>(portfolios);

            return map;
        }
        public async Task<PortfolioDto> GetPortfolioWithCategoryNonDeletedAsync(Guid portfolioId)
        {

            var portfolio = await unitOfWork.GetRepository<Portfolio>().GetAsync(x => !x.IsDeleted && x.Id == portfolioId, x => x.Category, s => s.Seo, l => l.Link, i => i.Image, u => u.User);
            var map = mapper.Map<PortfolioDto>(portfolio);

            return map;
        }
        public async Task<string> UpdatePortfolioAsync(PortfolioUpdateDto portfolioUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            var portfolio = await unitOfWork.GetRepository<Portfolio>().GetAsync(x => !x.IsDeleted && x.Id == portfolioUpdateDto.Id, x => x.Category, i => i.Image, s => s.Seo, l => l.Link);

            if (portfolioUpdateDto.Photo != null)
            {
                imageHelper.Delete(portfolio.Image.FileName);

                var imageUpload = await imageHelper.Upload(portfolioUpdateDto.Title, portfolioUpdateDto.Photo, ImageType.Work);
                Image image = new(imageUpload.FullName, portfolioUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                portfolio.ImageId = image.Id;

                if (portfolioUpdateDto.Image != portfolio.Image)
                {
                    portfolioUpdateDto.Image = image;
                }
            }
            else
            {
                portfolioUpdateDto.Image = portfolio.Image; // Keep the existing image if no image is selected
            }

            mapper.Map(portfolioUpdateDto, portfolio);

            portfolio.ModifiedDate = DateTime.Now;
            portfolio.ModifiedBy = userEmail;

            await unitOfWork.GetRepository<Portfolio>().UpdateAsync(portfolio);
            await unitOfWork.SaveAsync();

            return portfolio.Title;
        }


        public async Task<string> SafeDeletePortfolioAsync(Guid portfolioId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var portfolio = await unitOfWork.GetRepository<Portfolio>().GetByGuidAsync(portfolioId);

            portfolio.IsDeleted = true;
            portfolio.DeletedDate = DateTime.Now;
            portfolio.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Portfolio>().UpdateAsync(portfolio);
            await unitOfWork.SaveAsync();

            return portfolio.Title;
        }

        public async Task<List<PortfolioDto>> GetAllPortfoliosWithCategoryDeletedAsync()
        {
            var portfolios = await unitOfWork.GetRepository<Portfolio>().GetAllAsync(x => x.IsDeleted, s => s.Seo, x => x.Category, l => l.Link);
            var map = mapper.Map<List<PortfolioDto>>(portfolios);

            return map;
        }

        public async Task<string> UndoDeletePortfolioAsync(Guid portfolioId)
        {
            var portfolio = await unitOfWork.GetRepository<Portfolio>().GetByGuidAsync(portfolioId);

            portfolio.IsDeleted = false;
            portfolio.DeletedDate = null;
            portfolio.DeletedBy = null;

            await unitOfWork.GetRepository<Portfolio>().UpdateAsync(portfolio);
            await unitOfWork.SaveAsync();

            return portfolio.Title;
        }

        public async Task<PortfolioListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var portfolios = await unitOfWork.GetRepository<Portfolio>().GetAllAsync(
                a => !a.IsDeleted && (a.Title.Contains(keyword) || a.Content.Contains(keyword) || a.Category.Name.Contains(keyword)),
            a => a.Category, i => i.Image, u => u.User);

            var sortedPortfolios = isAscending
                ? portfolios.OrderBy(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : portfolios.OrderByDescending(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new PortfolioListDto
            {
                Portfolios = sortedPortfolios,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = portfolios.Count,
                IsAscending = isAscending
            };
        }
    }
}