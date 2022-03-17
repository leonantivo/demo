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
    public class GetPersonToListHandler : IRequestHandler<GetAllPerson, List<PersonModel>>
    {
        private readonly IPersonRepository data;

        public GetPersonToListHandler(IPersonRepository _data)
        {
            data = _data;
        }
        public Task<List<PersonModel>> Handle(GetAllPerson request, CancellationToken cancellationToken)
        {
            var person = data.GetData();
            return person == null ? null : person;
        }
    }
}
