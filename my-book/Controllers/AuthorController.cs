using Microsoft.AspNetCore.Mvc;
using my_book.Data.Services;
using my_book.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book.Controllers
{
    public class AuthorController : Controller
    {
        private AuthorService _authorservice;

        public AuthorController(AuthorService authorService)
        {
            _authorservice = authorService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody]AuthorVM authorVM)
        {
            _authorservice.AddAuthor(authorVM);
            return Ok();
        }
    }
}
