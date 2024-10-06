using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.DAL.Creator
{
    public class NaturalPersonCreator : PersonCreator
    {
        public override Person CreatePerson()
        {
            return new NaturalPerson();
        }
    }
}
