using DataLibrary.Model;
using DataLibrary.ViewModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DataLibrary.Commands.UpdatePerson;

namespace DataLibrary.Handler
{
    class UpdatePersonHandler : IRequestHandler<UpdatePersonRecord, PersonModel>
    {
        public Task<PersonModel> Handle(UpdatePersonRecord request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
