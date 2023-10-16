using AC.Core.Shared.ModelViews;
using FluentValidation;

namespace AC.Data.Validator
{
    public class NewCustomerValidator : AbstractValidator<NewCustomer>
    {

        public NewCustomerValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.Birthdate).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.SocialId).NotNull().NotEmpty().MinimumLength(11).MaximumLength(14);
            RuleFor(x => x.Phone).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("Minimun 10 digits");
        }
    }
}
