using System;
using System.Threading.Tasks;
using Contant.API.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ContactAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet("{id}", Name = "GetContactById")]
        public async Task<IActionResult> GetContactById(Guid id)
        {
            return Ok(await contactService.GetContactById(id));
        }
    }
}