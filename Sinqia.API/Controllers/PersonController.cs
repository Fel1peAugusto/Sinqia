using Microsoft.AspNetCore.Mvc;
using Sinqia.BLL.Interfaces;
using Sinqia.DAL.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Sinqia.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        //Dependecy Injection Service 
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        { 
            _personRepository = personRepository; 

        } 


        [HttpGet(Name = "CreatePerson")]
        [SwaggerOperation(Description = "Input PF to return a Natural person or PJ to return the a Legal Person", Summary = "CreatePerson")]
        public string CreatePerson(string tipo) 
        {
            if (tipo.ToUpper() == "PF" || tipo.ToUpper() == "PJ")
                return Newtonsoft.Json.JsonConvert.SerializeObject(_personRepository.CreatePerson(tipo));
            return "Input the correct type";
        }
    }
}
