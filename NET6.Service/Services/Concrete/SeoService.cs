using AutoMapper;
using Microsoft.AspNetCore.Http;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Seos;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using System.Security.Claims;

namespace NET6.Service.Services.Concrete
{
    public class SeoService : ISeoService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public SeoService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task CreateSeoAsync(SeoAddDto seoAddDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            Seo seo = new(seoAddDto.Author, seoAddDto.Description, seoAddDto.Keywords, userEmail);
            await unitOfWork.GetRepository<Seo>().AddAsync(seo);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<SeoDto>> GetAllSeosDeleted()
        {
            var seos = await unitOfWork.GetRepository<Seo>().GetAllAsync(x => x.IsDeleted);
            var map = mapper.Map<List<SeoDto>>(seos);

            return map;
        }

        public async Task<List<SeoDto>> GetAllSeosNonDeleted()
        {
            var seos = await unitOfWork.GetRepository<Seo>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<SeoDto>>(seos);

            return map;
        }

        public async Task<Seo> GetSeoByGuid(Guid id)
        {
            var seo = await unitOfWork.GetRepository<Seo>().GetByGuidAsync(id);
            return seo;
        }

        public async Task<string> SafeDeleteSeoAsync(Guid seoId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var seo = await unitOfWork.GetRepository<Seo>().GetByGuidAsync(seoId);

            seo.IsDeleted = true;
            seo.DeletedDate = DateTime.Now;
            seo.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Seo>().UpdateAsync(seo);
            await unitOfWork.SaveAsync();

            return seo.Author;
        }

        public async Task<string> UndoDeleteSeoAsync(Guid seoId)
        {
            var seo = await unitOfWork.GetRepository<Seo>().GetByGuidAsync(seoId);

            seo.IsDeleted = false;
            seo.DeletedDate = null;
            seo.DeletedBy = null;

            await unitOfWork.GetRepository<Seo>().UpdateAsync(seo);
            await unitOfWork.SaveAsync();

            return seo.Author;
        }

        public async Task<string> UpdateSeoAsync(SeoUpdateDto seoUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var seo = await unitOfWork.GetRepository<Seo>().GetAsync(x => !x.IsDeleted && x.Id == seoUpdateDto.Id);

            seo.Author = seoUpdateDto.Author;
            seo.Description = seoUpdateDto.Description;
            seo.Description = seoUpdateDto.Keywords;
            seo.ModifiedBy = userEmail;
            seo.ModifiedDate = DateTime.Now;


            await unitOfWork.GetRepository<Seo>().UpdateAsync(seo);
            await unitOfWork.SaveAsync();


            return seo.Author;
        }
    }
}
