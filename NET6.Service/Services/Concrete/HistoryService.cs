using AutoMapper;
using Microsoft.AspNetCore.Http;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Histories;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using System.Security.Claims;

namespace NET6.Service.Services.Concrete
{
    public class HistoryService : IHistoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public HistoryService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task CreateHistoryAsync(HistoryAddDto historyAddDto)
        {

            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();


            var history = new History(historyAddDto.Title, historyAddDto.Name, historyAddDto.Content, historyAddDto.SFDate, userEmail, userId, historyAddDto.CategoryId);


            await unitOfWork.GetRepository<History>().AddAsync(history);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<HistoryDto>> GetAllHistoriesWithCategoryNonDeletedAsync()
        {

            var histories = await unitOfWork.GetRepository<History>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<HistoryDto>>(histories);

            return map;
        }
        public async Task<HistoryDto> GetHistoryWithCategoryNonDeletedAsync(Guid historyId)
        {

            var history = await unitOfWork.GetRepository<History>().GetAsync(x => !x.IsDeleted && x.Id == historyId, x => x.Category, u => u.User);
            var map = mapper.Map<HistoryDto>(history);

            return map;
        }
        public async Task<string> UpdateHistoryAsync(HistoryUpdateDto historyUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var history = await unitOfWork.GetRepository<History>().GetAsync(x => !x.IsDeleted && x.Id == historyUpdateDto.Id, x => x.Category);


            mapper.Map(historyUpdateDto, history);
            //History.Title = HistoryUpdateDto.Title;
            //History.Content = HistoryUpdateDto.Content;
            //History.CategoryId = HistoryUpdateDto.CategoryId;
            history.ModifiedDate = DateTime.Now;
            history.ModifiedBy = userEmail;

            await unitOfWork.GetRepository<History>().UpdateAsync(history);
            await unitOfWork.SaveAsync();

            return history.Title;

        }
        public async Task<string> SafeDeleteHistoryAsync(Guid historyId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var history = await unitOfWork.GetRepository<History>().GetByGuidAsync(historyId);

            history.IsDeleted = true;
            history.DeletedDate = DateTime.Now;
            history.DeletedBy = userEmail;

            await unitOfWork.GetRepository<History>().UpdateAsync(history);
            await unitOfWork.SaveAsync();

            return history.Title;
        }

        public async Task<List<HistoryDto>> GetAllHistoriesWithCategoryDeletedAsync()
        {
            var histories = await unitOfWork.GetRepository<History>().GetAllAsync(x => x.IsDeleted, x => x.Category);
            var map = mapper.Map<List<HistoryDto>>(histories);

            return map;
        }

        public async Task<string> UndoDeleteHistoryAsync(Guid historyId)
        {
            var history = await unitOfWork.GetRepository<History>().GetByGuidAsync(historyId);

            history.IsDeleted = false;
            history.DeletedDate = null;
            history.DeletedBy = null;

            await unitOfWork.GetRepository<History>().UpdateAsync(history);
            await unitOfWork.SaveAsync();

            return history.Title;
        }
        public async Task<HistoryListDto> GetHistoriesByCategory(Guid? categoryId, bool isAscending = false)
        {

            var histories = categoryId == null
                ? await unitOfWork.GetRepository<History>().GetAllAsync(a => !a.IsDeleted, a => a.Category, u => u.User)
                : await unitOfWork.GetRepository<History>().GetAllAsync(a => a.CategoryId == categoryId && !a.IsDeleted, a => a.Category, u => u.User);

            return new HistoryListDto
            {
                Histories = histories,
                CategoryId = categoryId == null ? null : categoryId.Value,
                IsAscending = isAscending
            };
        }
        public async Task<HistoryListDto> GetSkillsByCategoryName(string categoryName, bool isAscending = false)
        {
            var histories = categoryName == null
            ? await unitOfWork.GetRepository<History>().GetAllAsync(a => !a.IsDeleted, a => a.Category, u => u.User)
            : await unitOfWork.GetRepository<History>().GetAllAsync(a => a.Category.Name == categoryName && !a.IsDeleted, a => a.Category, u => u.User);

            return new HistoryListDto
            {
                Histories = histories,
                CategoryName = categoryName,
                IsAscending = isAscending
            };
        }

    }
}