using NET6.Entity.DTOs.Links;
using NET6.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Service.Services.Abstractions
{
    public interface ILinkService
    {
        Task<List<LinkDto>> GetAllLinksNonDeleted();
        Task<List<LinkDto>> GetAllLinksDeleted();
        Task CreateLinkAsync(LinkAddDto linkAddDto);
        Task<Link> GetLinkByGuid(Guid id);
        Task<string> UpdateLinkAsync(LinkUpdateDto linkUpdateDto);
        Task<string> SafeDeleteLinkAsync(Guid linkId);
        Task<string> UndoDeleteLinkAsync(Guid linkId);
    }
}
