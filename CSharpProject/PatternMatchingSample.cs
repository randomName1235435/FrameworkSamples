namespace CSharpProject
{
    static class PatternMatchingSample
    {
        public static bool IsSample(this char c) => c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

        public static bool IsAnotherSample(this char c) => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
    }
}
