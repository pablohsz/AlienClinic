using AC.Core.Shared.ModelViews;
using FluentValidation;

namespace AC.Data.Validator
{
    public class AlterCustomerValidator : AbstractValidator<AlterCustomer>
    {

        public AlterCustomerValidator()
        {
            RuleFor(p => p.Id).NotNull().NotEmpty().GreaterThan(0);
            Include(new NewCustomerValidator());
        }
    }
}
