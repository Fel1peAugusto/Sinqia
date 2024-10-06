using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.DAL.Creator
{
    //Factory Method
    public abstract class PersonCreator
    {
        public abstract Person CreatePerson();
    }
}
 