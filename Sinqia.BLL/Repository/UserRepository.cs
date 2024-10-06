using Sinqia.BLL.Interfaces;
using SinqiaDAL.Models;
using SinqiaDAL.Validations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinqia.BLL.Repository
{
    public class UserRepository : IUserRepository
    {
        public string ValidateUser(string email, string password) 
        {
            var u = new UserModel
            {
                Email = email,
                Senha = password
            };
           
            UserValidator validator = new UserValidator();
            var v = validator.Validate(u);
            if (v.IsValid)
            {
                return "Email validated successfully!";
            }
            else
            {
                string erros = string.Empty;

                for (int i = 0; i < v.Errors.Count; i++)
                {
                    erros += v.Errors[i];
                    if (i < v.Errors.Count - 1)
                        erros += ",";
                    erros += "\n";
                }
                return erros;
            }
        }
    }
}
