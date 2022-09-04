using FluentValidation;


namespace FluentValidationProject
{
    public class SampleValidator : AbstractValidator<SampleClassToValidate>
    {
        public SampleValidator()
        {
            RuleFor(x => x.SampleProperty).NotEmpty();
            RuleFor(x => x.SampleProperty).NotEmpty().WithMessage("SampleProperty must be not empty.");
            RuleFor(x => x.SampleProperty).Must(SpecialValidate).WithMessage("SampleProperty must be not special.");
        }

        private bool SpecialValidate(int arg)
        {
            return true;
        }
    }

    public class SampleClassToValidate
    {
        public int SampleProperty { get; set; }
    }
}