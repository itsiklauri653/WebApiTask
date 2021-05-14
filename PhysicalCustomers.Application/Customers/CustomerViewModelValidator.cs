using FluentValidation;
using System;

namespace PhysicalCustomers.Application.Customers
{
    public class CustomerViewModelValidator : AbstractValidator<CustomerViewModel>
    {
        public CustomerViewModelValidator()
        {
            RuleFor(c => c.FirstName)
                .NotNull()
                .WithMessage("First Name must not be null!!!")
                .NotEmpty()
                .WithMessage("First Name must not be Empty!!!")
                .Length(2, 50)
                .WithMessage("First name must have 2-50 characters!!!")
                .Matches(@"^([a-zA-Z])|([ა-ჰ])*$")
                .WithMessage("Please enter either English or Georgian characters!!!");
            RuleFor(c => c.LastName)
                    .NotNull()
                    .WithMessage("Last name must not be null!!!")
                    .NotEmpty()
                    .WithMessage("Last Name must not be empty!!!")
                    .Length(2, 50)
                    .WithMessage("Last name must have 2-50 characters!!!")
                    .Matches(@"^([a-zA-Z])|([ა-ჰ])*$")
                    .WithMessage("Please enter either English or Georgian characters!!!");
            RuleFor(c => c.Gender).IsInEnum();
            RuleFor(c => c.PersonalId)
                .NotNull()
                .WithMessage("Personal Id must not be null!!!")
                .NotEmpty()
                .WithMessage("Personal Id must not be empty!!!")
                .Length(11)
                .WithMessage("Personal Id must not be less or more than 11 characters!!!");

            RuleFor(c => c.BirthDate)
                .NotNull()
                .WithMessage("Birth date must not be null!!!")
                .NotEmpty()
                .WithMessage("Birth date must not be empty!!!")
                .Must(c => IsValidDateOfBirth(c))
                .WithMessage("Customer must be at least 18 years old!!!");

        }

        private bool IsValidDateOfBirth(DateTime date)
        {
            DateTime current = DateTime.Today;

            int age = current.Year - Convert.ToDateTime(date).Year;

            return age >= 18;
        }
    }
}
