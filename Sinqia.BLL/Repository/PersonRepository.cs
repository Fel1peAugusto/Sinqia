using Sinqia.BLL.Interfaces;
using Sinqia.DAL.Creator;
using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.BLL.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public Person CreatePerson(string type)
        {
            if (type.ToUpper() == "PF") 
                return new NaturalPersonCreator().CreatePerson();
            else
                return new LegalPersonCreator().CreatePerson();
        }
    }
}
