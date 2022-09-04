using HarmonyLib;
using System;

namespace HarmonyProject
{
    [HarmonyPatch]
    internal class Sample
    {
        [HarmonyPatch(typeof(Sample), "SampleMethod")]
        private static void SampleAfterMethod()
        {
        }

        private static void SampleInitMethod()
        {
            var harmony = new Harmony("com.sample.patch");
            harmony.PatchAll();
        }

        public void SampleMethod()
        {
        }
    }
}