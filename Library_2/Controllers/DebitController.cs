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
    public class DebitController : ControllerBase
    {
        DebitRepozitory _debitRepozitory;
        public DebitController(DebitRepozitory debitRepozitory)
        {
            _debitRepozitory = debitRepozitory;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_debitRepozitory.GetDebits());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Add(Debit debit)
        {
            try
            {
                _debitRepozitory.AddDebit(debit);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IActionResult Delete(Debit debit)
        {
            try
            {
                _debitRepozitory.DeleteDebit(debit);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IActionResult Update(Debit debit)
        {
            try
            {
                _debitRepozitory.UpdateDebit(debit);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
