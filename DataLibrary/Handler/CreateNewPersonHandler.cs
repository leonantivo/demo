using DataLibrary.Commands;
using DataLibrary.DataAccess;
using DataLibrary.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLibrary.Handler
{
    public class CreateNewPersonHandler : IRequestHandler<CreateNewPerson, PersonModel>
    {
        private readonly IPersonRepository data;

        public CreateNewPersonHandler(IPersonRepository _data)
        {
            data = _data;
        }

        public async Task<PersonModel> Handle(CreateNewPerson request, CancellationToken cancellationToken)
        {
            if (request.Person != null)
            {
                await data.CreatePerson(request.Person);
                data.SaveChanges();
                return request.Person;
            }
            else
            {
                return null;
            }
        }
    }
}
