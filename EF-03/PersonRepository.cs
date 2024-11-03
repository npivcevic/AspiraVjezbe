using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_03
{
    internal class PersonRepository
    {
        DataContext _dataContext;

        public PersonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Person?> Get(int id)
        {
            return await _dataContext.People.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Person>> GetAll()
        {
            return await _dataContext.People.AsNoTracking().ToListAsync();
        }

        public async Task<Person> Create(Person person)
        {
            _dataContext.People.Add(person);

            await _dataContext.SaveChangesAsync();

            return person;
        }

        public async Task<Person?> Delete(int id)
        {
            Person? p = await Get(id);

            if (p == null)
            {
                return null;
            }

            _dataContext.People.Remove(p);
            await _dataContext.SaveChangesAsync();

            return p;
        }

        public async Task<Person?> Update(Person person)
        {
            Person? existingPerson = await Get(person.Id);

            if (existingPerson == null)
            {
                return null;
            }

            _dataContext.Entry(existingPerson).CurrentValues.SetValues(person);

            await _dataContext.SaveChangesAsync();

            return person;
        }
    }
}
