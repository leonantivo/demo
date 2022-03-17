using DataLibrary.DataAccess;
using DataLibrary.Model;
using DataLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLibrary.Handler
{
    class GetPersonByIDHandler : IRequestHandler<GetPersonByID, PersonModel>
    {
        private readonly IPersonRepository data;

        public GetPersonByIDHandler(IPersonRepository _data)
        {
            data = _data;
        }
        public async Task<PersonModel> Handle(GetPersonByID request, CancellationToken cancellationToken)
        {
            var person = await data.GetPersonById(request.id);
            return person == null ? null : person;
        }
    }
}
