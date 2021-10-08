using Library_2.Models;
using Library_2.Repozitory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        BookRepozitory _bookRepozitory;
        public BookController(BookRepozitory bookRepozitory)
        {
            _bookRepozitory = bookRepozitory;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_bookRepozitory.GetBooks());

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            try
            {
                _bookRepozitory.AddBooks(book);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();

            }
        }

        [HttpDelete]
        public IActionResult Delete(Book book)
        {
            try
            {
                _bookRepozitory.DeleteBooks(book);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update(Book book1)
        {
            try
            {
                _bookRepozitory.UpdateBook(book1);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
