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
    public class UserController : Controller
    {
        public UserRepozitory _userRepozitory;
        public UserController(UserRepozitory userRepozitory)
        {
            _userRepozitory = userRepozitory;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_userRepozitory.GetUsers());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
         public IActionResult Add(User user)
        {
            try
            {
                _userRepozitory.AddUsers(user);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
        [HttpDelete]
        public IActionResult Delete(User user)
        {
            try
            {
                _userRepozitory.DeleteUsers(user);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Update(User user)
        {
            try
            {
                _userRepozitory.UpdateUsers(user);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
