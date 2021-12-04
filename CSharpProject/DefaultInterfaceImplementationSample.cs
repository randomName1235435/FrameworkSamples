namespace CSharpProject
{
    interface DefaultInterfaceImplementationSample
    {

        void Sample(string sampleParam);
        void Sample(int sampleParam) {
            Sample(sampleParam.ToString());
        }
    }
}
