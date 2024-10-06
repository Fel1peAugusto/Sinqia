using Sinqia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.BLL.Interfaces
{
    public interface IPersonRepository
    {
        Person CreatePerson(string type);
    }
}
