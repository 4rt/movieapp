using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.ViewModels
{
    public class MovieViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }
    }
}
