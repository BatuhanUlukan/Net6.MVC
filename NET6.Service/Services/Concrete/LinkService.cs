using AutoMapper;
using Microsoft.AspNetCore.Http;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Links;
using NET6.Entity.Entities;
using NET6.Service.Extensions;
using NET6.Service.Services.Abstractions;
using System.Security.Claims;

namespace NET6.Service.Services.Concrete
{
    public class LinkService : ILinkService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public LinkService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }
        public async Task<List<LinkDto>> GetAllLinksNonDeleted()
        {

            var links = await unitOfWork.GetRepository<Link>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<LinkDto>>(links);

            return map;
        }
        public async Task<List<LinkDto>> GetAllLinksNonDeletedTake24()
        {
            var links = await unitOfWork.GetRepository<Link>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<LinkDto>>(links);

            return map.Take(24).ToList();
        }


        public async Task CreateLinkAsync(LinkAddDto linkAddDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            Link link = new(linkAddDto.Name, linkAddDto.Url, userEmail);
            await unitOfWork.GetRepository<Link>().AddAsync(link);
            await unitOfWork.SaveAsync();

        }
        public async Task<Link> GetLinkByGuid(Guid id)
        {
            var link = await unitOfWork.GetRepository<Link>().GetByGuidAsync(id);
            return link;
        }
        public async Task<string> UpdateLinkAsync(LinkUpdateDto linkUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var link = await unitOfWork.GetRepository<Link>().GetAsync(x => !x.IsDeleted && x.Id == linkUpdateDto.Id);

            link.Name = linkUpdateDto.Name;
            link.ModifiedBy = userEmail;
            link.ModifiedDate = DateTime.Now;


            await unitOfWork.GetRepository<Link>().UpdateAsync(link);
            await unitOfWork.SaveAsync();


            return link.Name;
        }

        public async Task<string> SafeDeleteLinkAsync(Guid linkId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var link = await unitOfWork.GetRepository<Link>().GetByGuidAsync(linkId);

            link.IsDeleted = true;
            link.DeletedDate = DateTime.Now;
            link.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Link>().UpdateAsync(link);
            await unitOfWork.SaveAsync();

            return link.Name;
        }

        public async Task<List<LinkDto>> GetAllLinksDeleted()
        {
            var links = await unitOfWork.GetRepository<Link>().GetAllAsync(x => x.IsDeleted);
            var map = mapper.Map<List<LinkDto>>(links);

            return map;
        }

        public async Task<string> UndoDeleteLinkAsync(Guid linkId)
        {
            var link = await unitOfWork.GetRepository<Link>().GetByGuidAsync(linkId);

            link.IsDeleted = false;
            link.DeletedDate = null;
            link.DeletedBy = null;

            await unitOfWork.GetRepository<Link>().UpdateAsync(link);
            await unitOfWork.SaveAsync();

            return link.Name;
        }


    }
}
