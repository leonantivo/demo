using DataLibrary.Model;
using DataLibrary.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
    public interface IPersonRepository
    {
        Task<List<PersonModel>> GetData();
        Task<PersonModel> GetPersonById(int id);
       Task<PersonModel> CreatePerson(PersonModel person);
        void SaveChanges();
       // Task<PersonModel> UpdatePerson(ModelUpdatePerson person);

    }

}