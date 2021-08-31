using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Features.Users.Command.UpdateUser
{
   public class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.FirstName).Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Please ensure you have entered your {PropertyName}")
               .MaximumLength(20).WithMessage("Please ensure you have maximum length your {PropertyName}")
               .Matches(@"^[\u0621-\u064Aa-zA-Z\s]+$").WithMessage("Invaild {PropertyName} not allow number");


            RuleFor(x => x.MiddleName).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please ensure you have entered your {PropertyName}")
                .MaximumLength(20).WithMessage("Please ensure you have maximum length your {PropertyName}")
                .Matches(@"^[\u0621-\u064Aa-zA-Z\s]+$").WithMessage("Invaild {PropertyName} not allow number");


            RuleFor(x => x.LastName).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please ensure you have entered your {PropertyName}")
                .MaximumLength(20).WithMessage("Please ensure you have maximum length your {PropertyName}")
                 .Matches(@"^[\u0621-\u064Aa-zA-Z\s]+$").WithMessage("Invaild {PropertyName} not allow number"); ;


            RuleFor(x => x.BirthDate).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please ensure you have entered your {PropertyName}")
                .Must(AgeBeOver20).WithMessage("Minimum age is 20 years");


            RuleFor(x => x.Email).Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please ensure you have entered your {PropertyName}").EmailAddress().WithMessage("Invalid Email Address");


            RuleFor(x => x.MobileNo).Cascade(CascadeMode.Stop).
                NotEmpty().WithMessage("Please ensure you have entered your {PropertyName}")
                .MinimumLength(11).WithMessage("Minimum number is 11")
                .MaximumLength(12).WithMessage("maximum number is 12");
            //.Matches(@"^\+[0-9]{12}$").WithMessage(" is not a valid phone number.");


        }
        private bool AgeBeOver20(DateTime date)
        {
            int CalculateAge = (DateTime.Today).Year - date.Year;
            if (CalculateAge >= 20)
                return true;

            return false;
        }
    }
}

