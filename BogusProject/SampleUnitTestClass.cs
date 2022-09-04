using Bogus;
using System.Text.Json;
using System.Threading.Tasks;
using UnitTestFrameworkSamples;

namespace BogusProject
{
    public class SampleUnitTestClass
    {
        public SampleClass SampleNestedClass { get; set; }

        public static async Task Main()
        {
            var fakerSampleClass = new Faker<SampleClass>()
                .RuleFor(x => x.SampleDateTimeProperty, x => x.Date.Future())
                .RuleFor(x => x.SampleIntProperty, x => x.UniqueIndex)
                .RuleFor(x => x.SampleStringProperty, x => x.Company.CompanyName());

            var fakerSampleUnitTestClass = new Faker<SampleUnitTestClass>()
                .RuleFor(x => x.SampleNestedClass, x => fakerSampleClass);

            var fake = fakerSampleClass.Generate();
            System.Console.WriteLine(JsonSerializer.Serialize(fake));
            System.Console.ReadLine();

            /*
             * Endless fake data generating
             */

            foreach (var item in fakerSampleClass.GenerateForever())
            {
                System.Console.WriteLine(JsonSerializer.Serialize(item));
                await Task.Delay(1000);
            }
        }
    }
}