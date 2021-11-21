using HarmonyLib;
using System;

namespace HarmonyProject
{
    [HarmonyPatch]
    class Sample
    {
        [HarmonyPatch(typeof(Sample), "SampleMethod")] 
        static void SampleAfterMethod() { }

        static void SampleInitMethod()
        {
            var harmony = new Harmony("com.sample.patch");
            harmony.PatchAll();
        }

        public void SampleMethod() { }
    }
}
