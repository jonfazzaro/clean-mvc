using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMovie.Models;
using MvcMovie.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Tests {

    public partial class The_movie_list_view_model {

        private static void AssertThatThisIsTheOnlyMovie(IEnumerable<Movie> movies, string title) {
            Assert.AreEqual(1, movies.Count());
            Assert.AreEqual(title, movies.First().Title);
        }

        private static MovieListViewModel GetMovieList() {
            var movies = new List<Movie>(){
                new Movie(){ ID = 1, Title = "Saw", Genre = "Horror", Price = 5M, Rating = "R", ReleaseDate = DateTime.Parse("10/29/2004")},
                new Movie(){ ID = 2, Title = "When Harry Met Sally", Genre = "RomCom", Price = 5M, Rating = "R", ReleaseDate = DateTime.Parse("7/21/1989")},
                new Movie(){ ID = 3, Title = "The Fantastic Mr. Fox", Genre = "Indie", Price = 5M, Rating = "PG", ReleaseDate = DateTime.Parse("11/29/2009")},
                new Movie(){ ID = 4, Title = "Phantasm", Genre = "Horror", Price = 5M, Rating = "R", ReleaseDate = DateTime.Parse("3/28/1979")},
            };

            return new MovieListViewModel(movies);
        }
    }
}
