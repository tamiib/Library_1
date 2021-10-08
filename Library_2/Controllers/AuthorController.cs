using Library_2.Models;
using Library_2.Repozitory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        public AuthorRepozitory _authorRepozitory;
        public AuthorController(AuthorRepozitory authorRepozitory)
        {
            _authorRepozitory = authorRepozitory;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_authorRepozitory.GetAuthors());
            }
            catch (Exception exception)
            {
                return BadRequest(exception.ToString());

            }
        }
        [HttpPost]
        public IActionResult Add(Author Author)
        {
            try
            {
                _authorRepozitory.AddAuthors(Author);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult Delete(Author Author)
        {
            try
            {
                _authorRepozitory.DeleteAuthors(Author);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Upadte(Author Autor)
        {
            try
            {
                _authorRepozitory.UpadteAuthors(Autor);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();

                throw;
            }
        }

    }
}
