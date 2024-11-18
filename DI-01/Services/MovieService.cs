using DI_01.Models;
using DI_01.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DI_01.Services
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _movieRepository.GetAll();
        }

        public async Task<Movie?> Get(int id)
        {
            return await _movieRepository.Get(id);
        }

        public async Task Update(Movie movie)
        {
            _movieRepository.Update(movie);
            await _movieRepository.Save();
        }

        public async Task<Movie> Insert(Movie movie)
        {
            _movieRepository.Insert(movie);
            await _movieRepository.Save();

            return movie;
        }

        public async Task<bool> Delete(int id)
        {
            Movie? movie = await _movieRepository.Get(id);
            if (movie == null)
            {
                return false;
            }
            _movieRepository.Delete(movie);
            await _movieRepository.Save();

            return true;
        }
    }
}
