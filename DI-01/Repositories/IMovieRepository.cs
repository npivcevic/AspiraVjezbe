using DI_01.Models;

namespace DI_01.Repositories
{
    public interface IMovieRepository
    {
        void Delete(Movie movie);
        Task<Movie?> Get(int id);
        Task<IEnumerable<Movie>> GetAll();
        void Insert(Movie movie);
        Task Save();
        void Update(Movie movie);
    }
}