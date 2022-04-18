namespace CSharpProject
{
    static class PatternMatchingSample
    {
        private const decimal defaultMargin = 1.5M;

        public static bool IsSample(this char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsAnotherSample(this char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

        public static void SampleMethod(object sampleObject)
        {
            if (sampleObject is object objectVariable)
            {
                objectVariable.ToString();
            }
            else
            {
                if (sampleObject is string { Length: 10 } stringSample)
                {
                    stringSample.ToString();
                }
            }

            switch (sampleObject)
            {
                case string sampleString when sampleString.Length > 0:
                    sampleString.ToString();
                    break;
                case object anotherObjectVariable:
                    anotherObjectVariable.ToString();
                    break;
                default:
                    break;

            }
            int result = sampleObject switch
            {
                object _ => 0,
                _ => -1, // default
            };
            if (sampleObject is PatternMatchingSampleSampleRecord { SampleIntProperty1: > 1 and < 3, SampleIntProperty2: >= 10 } pmssr)
            {
                var sampleRestult = pmssr.SampleIntProperty1 switch
                {
                    >= 10 and <= 20 => "",
                    _ => ""
                };
            }
        }
        static string SampleMethodSwitch(int intParam, string stringParam) => (intParam, stringParam) switch
        {
            ( <= 0, "") => "TestString",
            _ => ""
        };
        //AddDefaultMargin(baseprice)

        public static decimal CalculateCustomerPrice(decimal baseprice, int customerYears, bool customerBoughtLastYear) =>
            (baseprice > 5M, customerYears >= 5, customerBoughtLastYear) switch
            {
                (true, true, true) => 0.2M,
                (true, false, true) => 0.1M,
                (true, true, false) => 0.05M,
                _ => 0
            };
private static decimal AddDefaultMargin(decimal baseprice) => baseprice * defaultMargin;
        
    }
    record PatternMatchingSampleSampleRecord(int SampleIntProperty1, int SampleIntProperty2);
}
