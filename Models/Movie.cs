using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3), Required]
        [Display(Name = "Title")] //, ResourceType = typeof(Resources.Resources)
        public string? Title { get; set; }

        [Display(Name = "Release Data"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string? Genre { get; set; }
        
        [Range(1, 100), Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(5)]
        public string? Rating { get; set; }

        //row table care nu face apel la backend si forma pentru obiectul respectiv submit-add->button elements to MovieList, details button-not activated,  delete action ->button
    }
}
