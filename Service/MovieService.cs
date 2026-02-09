using BlazorDemoP25L066.Components.Models;
using System.Collections.ObjectModel;


namespace BlazorDemoP25L066.Service
{
    public class MovieService
    {


        private readonly List<Movie> _movies = new()
        {
            new Movie
            {
                Id = 1, Title = "Inception", Genre = "Sci-Fi", Director = "Christopher Nolan", Year = 2010,
                Fanart = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX1000_.jpg",
                Cast = new Collection<Actor> {
                    new Actor { Id = 1, Firstname = "Leonardo", Lastname = "DiCaprio" },
                    new Actor { Id = 2, Firstname = "Cillian", Lastname = "Murphy" }
                },
                BackArt="https://image.tmdb.org/t/p/original/s3TBrRGB1iav7gFOCNx3H31MoES.jpg"
            },
            new Movie
            {
                Id = 2, Title = "The Dark Knight", Genre = "Action", Director = "Christopher Nolan", Year = 2008,
                Fanart = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS7NrH97poYmjw4HVXVurK0DLb8LvoGnPxp6UDTFQ4taq1CPE4wECm50BO3J3YjE7GX3EnyJo1tuwFPkWpVfPDOQeTYtDSkEI5MdGIxF2qctQ&s=10g",
                Cast = new Collection<Actor> {
                    new Actor { Id = 3, Firstname = "Christian", Lastname = "Bale" },
                    new Actor { Id = 4, Firstname = "Heath", Lastname = "Ledger" }
                },
                BackArt="https://image.tmdb.org/t/p/original/nMKdUUepR0i5zn0y1T4CsSB5chy.jpg"
            },
            new Movie
            {
                Id = 3, Title = "Pulp Fiction", Genre = "Crime", Director = "Quentin Tarantino", Year = 1994,
                Fanart = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS8zH6uKebbP8HeJGNbYNflh4F4OM4KkckjPZ8p5gc8sEs1A43vx5JgRBcMBLz756rt8wdiEsf2-NSZ6a2xCFyhix4oIUBbCEr5DNzU-zWOBg&s=10",
                Cast = new Collection<Actor> {
                    new Actor { Id = 5, Firstname = "John", Lastname = "Travolta" },
                    new Actor { Id = 6, Firstname = "Samuel L.", Lastname = "Jackson" }
                },
                BackArt="https://image.tmdb.org/t/p/original/hQAvKUPjrh6Se3cf8arLIWxfXc.jpg"
            },
            new Movie
            {
                Id = 4, Title = "The Matrix", Genre = "Sci-Fi", Director = "Lana Wachowski", Year = 1999,
                Fanart = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSTJarxqTtR-1WJUgigFOBCYsG98IgjWVTCoyl0DS8Ni78zhklQxtOrJVfGPVDye9rVZJSoN21Uw0UvI3jqXxpsISR0ay3Itx3R_7pUKXk4ag&s=10",
                Cast = new Collection<Actor> {
                    new Actor { Id = 7, Firstname = "Keanu", Lastname = "Reeves" },
                    new Actor { Id = 8, Firstname = "Laurence", Lastname = "Fishburne" }
                },
                BackArt="https://image.tmdb.org/t/p/original/qdbesOjJnIOpwB2LPSK7h4c1XRC.jpg"
            },
            new Movie
            {
                Id = 5, Title = "Forrest Gump", Genre = "Drama", Director = "Robert Zemeckis", Year = 1994,
                Fanart = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNgCvxcHkfsvXoJWOdhaBEujpakYXdhIhw0nyROK6XnAMedEubbVUTL8FR_vJVa6LPxXXuGoER8Vo4jNUq7eBu6_w7aS3Pf7ohA_ZjfjT8&s=10g",
                Cast = new Collection<Actor> {
                    new Actor { Id = 9, Firstname = "Tom", Lastname = "Hanks" },
                    new Actor { Id = 10, Firstname = "Robin", Lastname = "Wright" }
                },
                BackArt="https://image.tmdb.org/t/p/original/6djvPNOcGb3qDXTp8JPoc14bh1n.jpg"
            },
            new Movie
            {
                Id = 6, Title = "Interstellar", Genre = "Sci-Fi", Director = "Christopher Nolan", Year = 2014,
                Fanart = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTGKSMoFSiZ_NroPImqSAfvelHSRhagKJTi5kbzVyfWJmu6Gp6mQltUtVsEA2uItKySLfl2rsDDCofyoFgVrVh5M5uzIKQG6TGItgY3_jex&s=10",
                Cast = new Collection<Actor> {
                    new Actor { Id = 11, Firstname = "Matthew", Lastname = "McConaughey" },
                    new Actor { Id = 12, Firstname = "Anne", Lastname = "Hathaway" }
                },BackArt="https://image.tmdb.org/t/p/original/xJHokMbljvjADYdit5fK5VQsXEG.jpg"
            },
            new Movie
            {
                Id = 7, Title = "The Godfather", Genre = "Crime", Director = "Francis Ford Coppola", Year = 1972,
                Fanart = "https://media.themoviedb.org/t/p/w220_and_h330_face/tgAwJgT1VRQYY97lsJAD3qubV1O.jpg",
                Cast = new Collection<Actor> {
                    new Actor { Id = 13, Firstname = "Marlon", Lastname = "Brando" },
                    new Actor { Id = 14, Firstname = "Al", Lastname = "Pacino" }
                },
                BackArt="https://image.tmdb.org/t/p/original/41xIKcLiM5ryfz4C9sZFcBOJGsK.jpg"
            },
            new Movie
            {
                Id = 8, Title = "Gladiator", Genre = "Action", Director = "Ridley Scott", Year = 2000,
                Fanart = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRU_2xrD89urKMVr0tEQdwuJ8VREghn_T6_5MtFY2u_7HOi0-KWxjEQYPOE7WsLPbIkPktJckf-l8TKZaD3SVeLCCEqTvL_XAVtl6j-zLkw&s=10",
                Cast = new Collection<Actor> {
                    new Actor { Id = 15, Firstname = "Russell", Lastname = "Crowe" },
                    new Actor { Id = 16, Firstname = "Joaquin", Lastname = "Phoenix" }
                },BackArt="https://image.tmdb.org/t/p/original/jhk6D8pim3yaByu1801kMoxXFaX.jpg"
            },
            new Movie
            {
                Id = 9, Title = "The Lion King", Genre = "Animation", Director = "Roger Allers", Year = 1994,
                Fanart = "https://www.themoviedb.org/t/p/w600_and_h900_face/n6UChiAOSTHGih2FBactLjA4Cdt.jpg",
                Cast = new Collection<Actor> {
                    new Actor { Id = 17, Firstname = "James Earl", Lastname = "Jones" },
                    new Actor { Id = 18, Firstname = "Jeremy", Lastname = "Irons" }
                },BackArt="https://image.tmdb.org/t/p/original/wn0xIQhUdihDiqTdVmWzvmloXVA.jpg"
            },
            new Movie
            {
                Id = 10, Title = "The Prestige", Genre = "Drama", Director = "Christopher Nolan", Year = 2006,
                Fanart = "https://m.media-amazon.com/images/I/619c+UQZaOL._AC_UF1000,1000_QL80_.jpg",
                Cast = new Collection<Actor> {
                    new Actor { Id = 19, Firstname = "Hugh", Lastname = "Jackman" },
                    new Actor { Id = 20, Firstname = "Christian", Lastname = "Bale" }
                },
                BackArt="https://image.tmdb.org/t/p/original/z3br1ub7spqGMkxgjgJSdM4DC21.jpg"
            }
        };


        // Méthode pour récupérer tous les films (pour MovieList)
        public List<Movie> GetAllMovies() => _movies;

        // Méthode pour récupérer un seul film (pour MovieDetails)
        public Movie? GetMovieById(int id) => _movies.FirstOrDefault(m => m.Id == id);

        // Méthode pour ajouter un film
        public void AddMovie(Movie movie)
        {
            movie.Id = _movies.Max(m => m.Id) + 1;
            _movies.Add(movie);
        }

        // Méthode pour updater un film
        public void UpdateMovie(Movie movie)
        {
            var existing = GetMovieById(movie.Id);
            if (existing != null)
            {
                existing.Title = movie.Title;
                existing.Genre = movie.Genre;
                existing.Director = movie.Director;
                existing.Year = movie.Year;
                existing.Fanart = movie.Fanart;
                existing.BackArt = movie.BackArt;
                existing.Cast = movie.Cast;
            }
        }

        // Méthode pour effacer un fichier
        public void DeleteMovie(int id)
        {
            var movie = GetMovieById(id);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
        }

        public void AddToFavorite(int id)
        {

            var movie = GetMovieById(id);
            if(movie != null)
            {
                movie.Favorit = true;
            }
        }
    }
}
