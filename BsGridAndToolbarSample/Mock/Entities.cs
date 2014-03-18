using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyGrid.Mock
{
    #region Context
    [Serializable]
    public class BFormsContext
    {
        public BFormsContext()
        {
            #region Movies

            Movies = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Title = "Jackass Presents: Bad Grandpa",
                    WeekendRevenue = 32.1m,
                    GrossRevenue = 32.1m,
                    ReleaseDate = new DateTime(2013, 10, 25),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Comedy}.ToArray()),
                    Rating = 7.0,
                    IsRecommended = false,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTg4NjIwMTI5OV5BMl5BanBnXkFtZTgwNjU1MTMyMDE@._V1_SY317_CR1,0,214,317_.jpg"
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Gravity",
                    WeekendRevenue = 20.1m,
                    GrossRevenue = 200.0m,
                    ReleaseDate = new DateTime(2013, 10, 04),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Drama, MovieGenre.SciFi, MovieGenre.Thriller}.ToArray()),
                    Rating = 8.6,
                    IsRecommended = true,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BNjE5MzYwMzYxMF5BMl5BanBnXkFtZTcwOTk4MTk0OQ@@._V1_SY317_CR0,0,214,317_.jpg"
                },
                new Movie()
                {
                    Id = 3,
                    Title = "Captain Phillips",
                    WeekendRevenue = 11.6m,
                    GrossRevenue = 69.9m,
                    ReleaseDate = new DateTime(2013, 09, 27),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Action, MovieGenre.Adventure, MovieGenre.Biography}.ToArray()),
                    Rating = 8.1,
                    IsRecommended = true,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTQzNzExMDg3Ml5BMl5BanBnXkFtZTgwODU1NzEzMDE@._V1_SX214_.jpg"
                },
                new Movie()
                {
                    Id = 4,
                    Title = "The Counselor",
                    WeekendRevenue = 7.84m,
                    GrossRevenue = 7.84m,
                    ReleaseDate = new DateTime(2013, 10, 25),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Crime, MovieGenre.Drama, MovieGenre.Thriller}.ToArray()),
                    Rating = 6.1,
                    IsRecommended = true,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTc3ODk0MTY0N15BMl5BanBnXkFtZTgwOTU2MTEzMDE@._V1_SY317_CR0,0,214,317_.jpg"
                },
                new Movie()
                {
                    Id = 5,
                    Title = "Cloudy with a Chance of Meatballs 2",
                    WeekendRevenue = 6.28m,
                    GrossRevenue = 101.00m,
                    ReleaseDate = new DateTime(2013, 09, 20),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Animation, MovieGenre.Comedy, MovieGenre.Family}.ToArray()),
                    Rating = 6.5,
                    IsRecommended = false,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTYzNDM0MDI1NF5BMl5BanBnXkFtZTcwNzQ5NzYxOQ@@._V1_SX214_.jpg"
                },
                new Movie()
                {
                    Id = 6,
                    Title = "Carrie",
                    WeekendRevenue = 5.99m,
                    GrossRevenue = 26.1m,
                    ReleaseDate = new DateTime(2013, 10, 18),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Drama, MovieGenre.Horror}.ToArray()),
                    Rating = 6.4,
                    IsRecommended = false,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTc1MDIyOTkxN15BMl5BanBnXkFtZTgwMTU1NzEzMDE@._V1_SY317_CR0,0,214,317_.jpg"
                },
                new Movie()
                {
                    Id = 7,
                    Title = "Escape Plan",
                    WeekendRevenue = 4.56m,
                    GrossRevenue = 17.6m,
                    ReleaseDate = new DateTime(2013, 10, 18),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Action, MovieGenre.Mystery, MovieGenre.Thriller}.ToArray()),
                    Rating = 7.2,
                    IsRecommended = false,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTk3OTcxMTEyNl5BMl5BanBnXkFtZTcwMDQ4MjQ2OQ@@._V1_SY317_CR0,0,214,317_.jpg"
                },
                new Movie()
                {
                    Id = 8,
                    Title = "12 Years a Slave",
                    WeekendRevenue = 2.13m,
                    GrossRevenue = 3.39m,
                    ReleaseDate = new DateTime(2013, 10, 18),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Biography, MovieGenre.Drama, MovieGenre.History}.ToArray()),
                    Rating = 8.2,
                    IsRecommended = false,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMjExMTEzODkyN15BMl5BanBnXkFtZTcwNTU4NTc4OQ@@._V1_SX214_.jpg"
                },
                new Movie()
                {
                    Id = 9,
                    Title = "Enough Said",
                    WeekendRevenue = 1.59m,
                    GrossRevenue = 13.1m,
                    ReleaseDate = new DateTime(2013, 09, 13),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Comedy}.ToArray()),
                    Rating = 7.5,
                    IsRecommended = true,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMjI2MjIwMDk2Ml5BMl5BanBnXkFtZTcwNTQ1MzQ5OQ@@._V1_SX214_.jpg"
                },
                new Movie()
                {
                    Id = 10,
                    Title = "Prisoners",
                    WeekendRevenue = 1.07m,
                    GrossRevenue = 59.1m,
                    ReleaseDate = new DateTime(2013, 09, 13),
                    Genres = string.Join(",", new List<MovieGenre>() {MovieGenre.Crime, MovieGenre.Drama, MovieGenre.Thriller}.ToArray()),
                    Rating = 8.1,
                    IsRecommended = false,
                    Poster =
                        "http://ia.media-imdb.com/images/M/MV5BMTg0NTIzMjQ1NV5BMl5BanBnXkFtZTcwNDc3MzM5OQ@@._V1_SY317_CR0,0,214,317_.jpg"
                }

            };

            #endregion
        }

        public List<Movie> Movies { get; set; }

        public void SaveChanges()
        {
            HttpContext.Current.Session["DbContext"] = this;
        }

        public static BFormsContext Get()
        {
            var sessionContext = (BFormsContext)HttpContext.Current.Session["DbContext"];

            if (sessionContext == null)
            {
                sessionContext = new BFormsContext();

                HttpContext.Current.Session["DbContext"] = sessionContext;
            }

            return sessionContext;
        }
    }
    #endregion

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal WeekendRevenue { get; set; }
        public decimal GrossRevenue { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genres { get; set; } //comma separated list
        public double Rating { get; set; }
        public bool IsRecommended { get; set; }
        public string Poster { get; set; }
    }
}