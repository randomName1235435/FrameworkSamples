namespace SimpleValidatorProject.V1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleValidator<T>
    {
        private readonly List<Func<T, SimpleValidationResult<T>>> rules;

        public SimpleValidator() : this(Enumerable.Empty<Func<T, SimpleValidationResult<T>>>()) { }

        private SimpleValidator(IEnumerable<Func<T, SimpleValidationResult<T>>> rules2)
        {
            this.rules = new List<Func<T, SimpleValidationResult<T>>>(rules2);
        }

        public IEnumerable<SimpleValidationResult<T>> Validate(T objectToValidate)
        {
            return this.rules.Select(rule => rule(objectToValidate)).Where(x => x != null);
        }

        public SimpleValidator<T> AddRule(Func<T, string> rule)
        {
            var validator = new SimpleValidator<T>(this.rules);
            validator.rules.Add(
                                x =>
                                {
                                    var msg = rule(x);
                                    return msg == null ? null : new SimpleValidationResult<T> { Message = msg, ValidatedObject = x };
                                });

            return validator;
        }

        public SimpleValidator<T> AddRule(Func<T, SimpleValidationResult<T>> rule)
        {
            var validator = new SimpleValidator<T>(this.rules);
            validator.rules.Add(rule);

            return validator;
        }
    }
}