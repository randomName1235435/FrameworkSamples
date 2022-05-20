namespace AutofacSample
{
    public class SampleClass : ISampleInterface
    {

        public SampleClass(ISampleInterface sample)
        {
            Bootstrapper.Run();
        }



    }
}


