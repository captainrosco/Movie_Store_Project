using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieProject.Models;
using System.ComponentModel.DataAnnotations

namespace MovieProject.ViewModels
{
    public class NewMovieViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int Stock { get; set; }

        [Required]
        [Display( Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

    }
}