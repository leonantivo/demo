using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Model;
using MediatR;
namespace DataLibrary.Queries
{
    public record GetAllPerson() : IRequest<List<PersonModel>>; 
}
