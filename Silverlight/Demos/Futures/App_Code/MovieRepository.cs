using System.Collections.Generic;

public class MovieRepository
{
    public IList<Movie> GetAllMovies() 
    {
        List<Movie> movies = new List<Movie>();
        movies.Add(new Movie { Name = "Bear", Url = "~/media/Bear.wmv" });
        movies.Add(new Movie { Name = "Butterfly", Url = "~/media/Butterfly.wmv" });
        movies.Add(new Movie { Name = "Lake", Url = "~/media/Lake.wmv" });
        movies.Add(new Movie { Name = "Trailer", Url = "~/media/trailer.wmv" });

        return movies;
    }
}
