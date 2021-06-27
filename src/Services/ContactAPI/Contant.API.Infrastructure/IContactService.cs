using System;
using System.Threading.Tasks;
using Contant.API.Models;

namespace Contant.API.Infrastructure
{
    public interface IContactService
    {
        Task<ContactDTO> GetContactById(Guid id);
    }
}
