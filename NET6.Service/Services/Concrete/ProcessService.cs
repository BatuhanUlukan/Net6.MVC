using AutoMapper;
using Microsoft.AspNetCore.Http;
using NET6.Data.Migrations;
using NET6.Data.UnitOfWorks;
using NET6.Entity.DTOs.Portfolios;
using NET6.Entity.DTOs.Processes;
using NET6.Entity.Entities;
using NET6.Entity.Enums;
using NET6.Service.Extensions;
using NET6.Service.Helpers.Images;
using NET6.Service.Services.Abstractions;
using System.Security.Claims;



namespace NET6.Service.Services.Concrete
{
    public class ProcessService : IProcessService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public ProcessService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
            this.imageHelper = imageHelper;
        }



        public async Task<List<ProcessDto>> GetAllProcessesNonDeletedAsync()
        {

            var processes = await unitOfWork.GetRepository<Process>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<ProcessDto>>(processes);

            return map;
        }
        public async Task<ProcessDto> GetProcessesNonDeletedAsync(Guid processId)
        {

            var processes = await unitOfWork.GetRepository<Process>().GetAsync(x => !x.IsDeleted && x.Id == processId, i => i.Image, u => u.User);
            var map = mapper.Map<ProcessDto>(processes);

            return map;
        }
        public async Task<string> UpdateProcessAsync(ProcessUpdateDto processUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            var process = await unitOfWork.GetRepository<Process>().GetAsync(x => !x.IsDeleted && x.Id == processUpdateDto.Id, i => i.Image);


            if (processUpdateDto.Photo != null)
            {

                imageHelper.Delete(process.Image.FileName);

                var imageUpload = await imageHelper.Upload(processUpdateDto.Title, processUpdateDto.Photo, ImageType.Service);
                Image image = new(imageUpload.FullName, processUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                process.ImageId = image.Id;

                if (processUpdateDto.Image != process.Image)
                {
                    processUpdateDto.Image = image;
                }
                else
                {
                    processUpdateDto.Image = process.Image; // Keep the existing image if no image is selected
                }
            }


            mapper.Map(processUpdateDto, process);

            process.ModifiedDate = DateTime.Now;
            process.ModifiedBy = userEmail;


            await unitOfWork.GetRepository<Process>().UpdateAsync(process);
            await unitOfWork.SaveAsync();

            return process.Title;
        }

        public async Task<string> UndoDeleteProcessAsync(Guid processId)
        {
            var process = await unitOfWork.GetRepository<Process>().GetByGuidAsync(processId);

            process.IsDeleted = false;
            process.DeletedDate = null;
            process.DeletedBy = null;

            await unitOfWork.GetRepository<Process>().UpdateAsync(process);
            await unitOfWork.SaveAsync();

            return process.Title;
        }
        public async Task<string> SafeDeleteProcessAsync(Guid processId)
        {
            var userEmail = _user.GetLoggedInEmail();
            var process = await unitOfWork.GetRepository<Process>().GetByGuidAsync(processId);

            process.IsDeleted = true;
            process.DeletedDate = DateTime.Now;
            process.DeletedBy = userEmail;

            await unitOfWork.GetRepository<Process>().UpdateAsync(process);
            await unitOfWork.SaveAsync();

            return process.Title;
        }




        public async Task<List<ProcessDto>> GetAllProcessesDeletedAsync()
        {
            var processes = await unitOfWork.GetRepository<Process>().GetAllAsync(x => x.IsDeleted);
            var map = mapper.Map<List<ProcessDto>>(processes);

            return map;
        }

        public async Task CreateProcessAsync(ProcessAddDto processAddDto)
        {
            var userId = _user.GetLoggedInUserId();
            var userEmail = _user.GetLoggedInEmail();

            var imageUpload = await imageHelper.Upload(processAddDto.Title, processAddDto.Photo, ImageType.Service);
            Image image = new(imageUpload.FullName, processAddDto.Photo.ContentType, userEmail);
            await unitOfWork.GetRepository<Image>().AddAsync(image);

            var process = new Process(processAddDto.Title, processAddDto.Content, userId, userEmail, image.Id);

            await unitOfWork.GetRepository<Process>().AddAsync(process);
            await unitOfWork.SaveAsync();
        }

        public async Task<ProcessListDto> GetAllByPagingAsync()
        {
            var processes = await unitOfWork.GetRepository<Process>().GetAllAsync(a => !a.IsDeleted, i => i.Image, u => u.User);

            return new ProcessListDto
            {
                Processes = processes
            };
        }
    }
}