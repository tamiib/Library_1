using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Models
{
    public class Debit
    {
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
