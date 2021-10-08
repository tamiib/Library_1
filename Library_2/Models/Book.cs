using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Availability { get; set; }
       
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        //public Author Author { get; set; }
    }
}
