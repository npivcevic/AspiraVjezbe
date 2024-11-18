using DI_01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DI_01.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie?> Get(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public void Update(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
        }
        public void Insert(Movie movie)
        {
            _context.Movies.Add(movie);
        }
        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
