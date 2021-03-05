using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name ="Released Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name ="Genre")]
        public int GenreId { get; set; }
        [Required]
        public decimal Price { get; set; }

        public string Image { get; set; }
        public Genre Genre { get; set; }
    }
}