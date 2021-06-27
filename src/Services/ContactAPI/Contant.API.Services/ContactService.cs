using System;
using System.Threading.Tasks;
using Contant.API.Infrastructure;
using Contant.API.Models;

namespace Contant.API.Services
{
    public class ContactService : IContactService
    {
        public async Task<ContactDTO> GetContactById(Guid id)
        {
            return await Task.FromResult(new ContactDTO { Id = id, FirstName = "Gokberk", LastName = "Yildirim" });
        }
    }
}
