using FluentValidation;
using SinqiaDAL.Models;

namespace SinqiaDAL.Validations
{
    public class UserValidator :  AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(c => c.Email)
              .NotNull().WithMessage("Email is required")
              .NotEmpty().WithMessage("Email is required")
              .MinimumLength(10).WithMessage("Email must have more than 10 characters")
              .MaximumLength(50).WithMessage("Email must have less than 50 characters")
              .Matches("@").WithMessage("Invalid Email");

            RuleFor(c => c.Senha)
                        .NotNull().WithMessage("Passowrd is required")
                        .NotEmpty().WithMessage("Passowrd is required")
                        .MinimumLength(6).WithMessage("Passowrd must have more than 6 characters")
                        .MaximumLength(50).WithMessage("Passowrd must have less than 50 characters")
                        .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("Passowrd must have a special character");
        }
    }
}