using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Title is required.")]
        [MaxLength(15)]
        [MinLength(3)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

         [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}