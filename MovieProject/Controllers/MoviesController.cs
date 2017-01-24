using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieProject.Models;
using MovieProject.ViewModels;

namespace MovieProject.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movies
            };

            return View(viewModel);
        }

        public ActionResult Details(int? id)
        {
            var movies = _context.Movies.SingleOrDefault(c => c.Id == id);
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult New(Movie movie)
        {
            if(movie.Id == 0)
            {
                movie.DateAdded = DateTime.Today.ToString();
                _context.Movies.Add(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(Movie movie)
        {
            var _movie = _context.Movies.Single(m => m.Id == movie.Id);
            _movie.Name = movie.Name;
            _movie.Genre = movie.Genre;
            _movie.ReleaseDate = movie.ReleaseDate;
            _movie.DateAdded = movie.DateAdded;
            _movie.Stock = movie.Stock;
            return View();
        }
    }
}