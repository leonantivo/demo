using DataLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ProjectDbContext data;

        public PersonRepository(ProjectDbContext _data)
        {
            data = _data;
        }

        public async Task<PersonModel> CreatePerson(PersonModel person)
        {
            await data.Persons.AddAsync(person);
            return person;
        }

        public async Task<List<PersonModel>> GetData()
        {
            return await data.Persons.ToListAsync();
        }
        public async Task<PersonModel> GetPersonById(int id)
        {
            return await data.Persons.FindAsync(id);
        }

        public void SaveChanges()
        {
            data.SaveChanges();
        }

        //public async Task<PersonModel> UpdatePerson(PersonModel person)
        //{
        //    var p = await data.Persons.FindAsync(person.Id);
        //    p.FirstName = person.FirstName;
        //    p.LastName = person.LastName;
        //    return p;
        //}
    }
}
