    using AutoMapper;
    using Microsoft.AspNetCore.Http;
    using NET6.Data.UnitOfWorks;
    using NET6.Entity.DTOs.Socials;
    using NET6.Entity.Entities;
    using NET6.Service.Extensions;
    using NET6.Service.Helpers.Images;
    using NET6.Service.Services.Abstractions;
    using System.Security.Claims;


    namespace NET6.Service.Services.Concrete
    {
        public class SocialService : ISocialService
        {
            private readonly IUnitOfWork unitOfWork;
            private readonly IMapper mapper;
            private readonly IHttpContextAccessor httpContextAccessor;
            private readonly IImageHelper imageHelper;
            private readonly ClaimsPrincipal _user;

            public SocialService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
            {
                this.unitOfWork = unitOfWork;
                this.mapper = mapper;
                this.httpContextAccessor = httpContextAccessor;
                _user = httpContextAccessor.HttpContext.User;
                this.imageHelper = imageHelper;
            }

            public async Task CreateSocialAsync(SocialAddDto socialAddDto)
            {
                var userId = _user.GetLoggedInUserId();
                var userEmail = _user.GetLoggedInEmail();



                var social = new Social(socialAddDto.Icon, socialAddDto.Name, userEmail, socialAddDto.LinkId);

                await unitOfWork.GetRepository<Social>().AddAsync(social);
                await unitOfWork.SaveAsync();
            }

            public async Task<List<SocialDto>> GetAllSocialsNonDeletedAsync()
            {

                var socials = await unitOfWork.GetRepository<Social>().GetAllAsync(x => !x.IsDeleted, l => l.Link);
                var map = mapper.Map<List<SocialDto>>(socials);

                return map;
            }
            public async Task<SocialDto> GetSocialNonDeletedAsync(Guid socialId)
            {

                var social = await unitOfWork.GetRepository<Social>().GetAsync(x => !x.IsDeleted && x.Id == socialId, l => l.Link);
                var map = mapper.Map<SocialDto>(social);

                return map;
            }

            public async Task<string> SafeDeleteSocialAsync(Guid socialId)
            {
                var userEmail = _user.GetLoggedInEmail();
                var social = await unitOfWork.GetRepository<Social>().GetByGuidAsync(socialId);

                social.IsDeleted = true;
                social.DeletedDate = DateTime.Now;
                social.DeletedBy = userEmail;

                await unitOfWork.GetRepository<Social>().UpdateAsync(social);
                await unitOfWork.SaveAsync();

                return social.Name;
            }

            public async Task<List<SocialDto>> GetAllSocialsDeletedAsync()
            {
                var socials = await unitOfWork.GetRepository<Social>().GetAllAsync(x => x.IsDeleted, l => l.Link);
                var map = mapper.Map<List<SocialDto>>(socials);

                return map;
            }

            public async Task<string> UndoDeleteSocialAsync(Guid socialId)
            {
                var social = await unitOfWork.GetRepository<Social>().GetByGuidAsync(socialId);

                social.IsDeleted = false;
                social.DeletedDate = null;
                social.DeletedBy = null;

                await unitOfWork.GetRepository<Social>().UpdateAsync(social);
                await unitOfWork.SaveAsync();

                return social.Name;
            }

            public async Task<string> UpdateSocialAsync(SocialUpdateDto socialUpdateDto)
            {
                var userEmail = _user.GetLoggedInEmail();

                var social = await unitOfWork.GetRepository<Social>().GetAsync(x => !x.IsDeleted && x.Id == socialUpdateDto.Id, l => l.Link);



                mapper.Map(socialUpdateDto, social);

                social.ModifiedDate = DateTime.Now;
                social.ModifiedBy = userEmail;


                await unitOfWork.GetRepository<Social>().UpdateAsync(social);
                await unitOfWork.SaveAsync();

                return social.Name;
            }

        }
    }