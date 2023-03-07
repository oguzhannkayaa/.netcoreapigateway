﻿using Contact.API.Infrastructure;
using Contact.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{Id}")]
        public ContactDTO Get(int Id)
        {
            return _contactService.GetContactById(Id);

        }

    }
}
