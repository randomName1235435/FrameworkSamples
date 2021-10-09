namespace SimpleValidatorProject.V1
{
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleValidationResult<T>
    {
        public SimpleValidationResult()
        {
            this.PropertyPaths = new List<string>();
        }

        public T ValidatedObject { get; set; }

        public string Message { get; set; }

        public List<string> PropertyPaths { get; set; }
    }

    public static class SimpleValidationResult
    {
        public static SimpleValidationResult<T> Create<T>(T validatedObject, string msg, params string[] propertyPaths)
        {
            return new SimpleValidationResult<T>
            {
                ValidatedObject = validatedObject,
                PropertyPaths = propertyPaths.ToList(),
                Message = msg
            };
        }
    }
}
