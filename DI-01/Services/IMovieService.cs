using DI_01.Models;

namespace DI_01.Services
{
    public interface IMovieService
    {
        Task<bool> Delete(int id);
        Task<Movie?> Get(int id);
        Task<IEnumerable<Movie>> GetAll();
        Task<Movie> Insert(Movie movie);
        Task Update(Movie movie);
    }
}