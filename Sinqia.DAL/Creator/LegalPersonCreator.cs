using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.DAL.Creator
{
    public class LegalPersonCreator : PersonCreator
    {
        public override Person CreatePerson()
        {
            return new LegalPerson();
        }
    }
}
