using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }
        public string Plot { get; set; }
        public virtual CategoryDto Category { get; set; }
        public int? CategoryId { get; set; }
        public int Year { get; set; }
        public double Rating { get; set; }
        public string Poster { get; set; }
    }
}
