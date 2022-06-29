using Core.Entities;
using Core.Interfaces;

namespace Core.Services;
public class MovieService : IMovieService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMovieRepository _movieRepository;

    public MovieService(IUnitOfWork unitOfWork, IMovieRepository movieRepository)
    {
        _unitOfWork = unitOfWork;
        _movieRepository = movieRepository;
    }

    public ICollection<Movie> GetList()
    {
        return _movieRepository.GetAll();
    }

    public void Add(Movie movie)
    {
        _movieRepository.Insert(movie);
        _unitOfWork.SaveChanges();
    }
}