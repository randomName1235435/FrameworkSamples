using LanguageExt.Common;

namespace LanguageExtProject
{
    internal class ResultSample
    {
        private Result<bool> Sample()
        {

            var sampleException = new Exception();

            return new Result<bool>(sampleException);
        }

        private bool SampleMatch()
        {
            return Sample().Match<bool>(r =>
            {
                return r;
            },
            e =>
            {
                Console.WriteLine(e.Message);
                return false;
            }
            );
        }
    }
}
