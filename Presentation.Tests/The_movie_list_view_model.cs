using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcMovie.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcMovie.Tests {

    [TestClass]
    public partial class The_movie_list_view_model {

        [TestMethod]
        public void has_a_title() {
            var model = GetMovieList();
            Assert.AreEqual("Movies", model.Title);
        }

        [TestMethod]
        public void has_a_list_of_movies() {
            var model = GetMovieList();
            Assert.IsInstanceOfType(model.Movies, typeof(IEnumerable<Movie>));
        }

        [TestMethod]
        public void gets_the_movies_from_the_constructor() {
            var model = GetMovieList();
            Assert.AreEqual(4, model.Movies.Count());
        }

        [TestMethod]
        public void has_a_list_of_genres() {
            var model = GetMovieList();
            Assert.IsInstanceOfType(model.Genres, typeof(IEnumerable<string>));
        }

        [TestMethod]
        public void gets_the_genres_from_the_movies() {
            var model = GetMovieList();
            Assert.AreEqual(3, model.Genres.Count());
        }

        [TestMethod]
        public void filters_the_list_of_movies_by_genre() {
            var model = GetMovieList();
            model.Genre = "RomCom";
            AssertThatThisIsTheOnlyMovie(model.Movies, "When Harry Met Sally");
        }

        [TestMethod]
        public void shows_all_movies_when_no_genre_is_selected() {
            var model = GetMovieList();
            model.Genre = "";
            Assert.AreEqual(4, model.Movies.Count());
        }

        [TestMethod]
        public void filters_the_list_of_movies_by_searching_the_title() {
            var model = GetMovieList();
            model.Filter = "The";
            AssertThatThisIsTheOnlyMovie(model.Movies, "The Fantastic Mr. Fox");
        }

        [TestMethod]
        public void ignores_case_when_filtering_the_title() {
            var model = GetMovieList();
            model.Filter = "the";
            AssertThatThisIsTheOnlyMovie(model.Movies, "The Fantastic Mr. Fox");
        }

        [TestMethod]
        public void shows_all_movies_when_no_search_string_is_given() {
            var model = GetMovieList();
            model.Filter = "";
            Assert.AreEqual(4, model.Movies.Count());
        }

        [TestMethod]
        public void has_a_sample_movie() {
            var model = GetMovieList();
            Assert.IsInstanceOfType(model.Sample, typeof(Movie));
        }
    }
}
