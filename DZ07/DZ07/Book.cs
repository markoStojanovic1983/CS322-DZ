using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ07
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        public required string Title { get; set; }

        public int AuthorID { get; set; }

        public required string Genre { get; set; }

        public required string ISBN { get; set; }

        public Author Author { get; set; }
    }
}
