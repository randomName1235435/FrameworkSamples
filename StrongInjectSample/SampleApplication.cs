﻿namespace StrongInjectSample
{
    internal class SampleApplication
    {
        private readonly ISampleService sampleService;

        public SampleApplication(ISampleService sampleService)
        {
            this.sampleService = sampleService;
        }
    }
}