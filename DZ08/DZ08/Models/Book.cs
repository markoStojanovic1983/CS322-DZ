using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DZ08.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 200 characters")]
        [Display(Name = "Book Title")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an author")]
        [Display(Name = "Author")]
        public int AuthorID { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Genre must be between 3 and 50 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Genre must start with a capital letter")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "ISBN is required")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "ISBN must be between 10 and 20 characters")]
        [Display(Name = "ISBN")]
        [RegularExpression(@"^[\d\-]+$", ErrorMessage = "ISBN can only contain numbers and dashes")]
        public string ISBN { get; set; } = string.Empty;

        [Column(TypeName = "decimal(8, 2)")]
        [Display(Name = "Price ($)")]
        [Range(0.01, 999.99, ErrorMessage = "Price must be between $0.01 and $999.99")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [PublicationYear]
        public DateTime PublicationDate { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars")]
        [Display(Name = "Rating (1-5 stars)")]
        public int Rating { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        // Navigation property
        [ForeignKey("AuthorID")]
        public Author? Author { get; set; }
    }
}