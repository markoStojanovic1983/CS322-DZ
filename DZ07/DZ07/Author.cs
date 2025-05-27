using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ07
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
