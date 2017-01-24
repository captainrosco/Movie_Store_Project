using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string Genre { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public int Stock { get; set; }

        [Required]
        public string ReleaseDate { get; set; }

        [Required]
        public string DateAdded { get; set; }
    }

}