using Core.Entities;

namespace Core.Interfaces;

public interface IMovieService
{
    ICollection<Movie> GetList();
    void Add(Movie movie);
}