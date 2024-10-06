using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Sinqia.DAL.Models
{
    public abstract class Person
    {
        [JsonProperty]
        protected string Name { get; }
        

        public Person(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
