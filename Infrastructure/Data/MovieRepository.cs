using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data;
public class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    public MovieRepository(DatabaseContext context) : base(context)
    {
    }
}