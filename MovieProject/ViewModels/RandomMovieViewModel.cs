using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieProject.Models;

namespace MovieProject.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movie { get; set; }
        public List<Customer> Customer { get; set; }
    }
}