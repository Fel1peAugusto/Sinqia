using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sinqia.BLL.Interfaces;
using Sinqia.BLL.Repository;
using SinqiaDAL.Models;
using SinqiaDAL.Validations;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SinqiaAPI.Controllers
{
    [ApiController]
    
    [Route("api/[controller]")] 
    public class UserController
    {        
        //Dependecy Injection Service
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //User Validations
        [HttpGet(Name = "ValidateUser")]
        [SwaggerOperation(Description = "Validates the email and password of a user", Summary = "ValidateUser")]
        public string ValidateUser(string email, string password)
        {
           return _userRepository.ValidateUser(email, password);
        }
    }
}
