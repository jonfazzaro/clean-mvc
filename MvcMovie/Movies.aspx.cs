using MvcMovie.Models;
using MvcMovie.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MvcMovie.Web {
    public partial class Movies : System.Web.UI.Page {

        private readonly MovieDBContext _db = new MovieDBContext();
        private readonly MovieListViewModel _model;

        public Movies() {
            _model = new MovieListViewModel(_db.Movies);
        }

        protected void Page_Load(object sender, EventArgs e) {
            BindGenreDropDown();
            BindFilterAndGenre();
            BindMoviesGrid();
        }

        private void BindFilterAndGenre() {
            _model.Filter = TextBox1.Text;
            _model.Genre = DropDownList1.SelectedValue;
        }

        private void BindMoviesGrid() {
            GridView1.DataSource = _model.Movies;
            GridView1.DataBind();
        }

        private void BindGenreDropDown() {
            if (!IsPostBack) {
                DropDownList1.DataSource = _model.Genres;
                DropDownList1.DataBind();
            }
        }
    }
}