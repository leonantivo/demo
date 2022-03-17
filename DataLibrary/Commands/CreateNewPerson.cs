using DataLibrary.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Commands
{
    public record CreateNewPerson(PersonModel Person) : IRequest<PersonModel>; 
   
}
