namespace CSharpProject.Keywords;

internal class OperatorSample
{
    private void BinarySample()
    {
        var sampleOne = 0;
        var sampleTwo = 1;
        var result = 0;

        result = sampleOne + sampleTwo;
        result = sampleOne - sampleTwo;
        result = sampleOne * sampleTwo;
        result = sampleOne / sampleTwo;
        result = sampleOne % sampleTwo;
        result = sampleOne & sampleTwo;
        result = sampleOne | sampleTwo;
        result = sampleOne << sampleTwo;
        result = sampleOne >> sampleTwo;
    }

    private void UnarySample()
    {
        var sampleOne = 0;
        var sampleTwo = 1;
        var result = 0;

        result = sampleOne!;
        result = ~sampleOne;
        result = sampleOne++;
        result = sampleOne--;
        result = sampleOne;
    }

    private void RelationalSample()
    {
        var sampleOne = 0;
        var sampleTwo = 1;
        var result = false;

        result = sampleOne == sampleTwo;
        result = sampleOne != sampleTwo;
        result = sampleOne < sampleTwo;
        result = sampleOne > sampleTwo;
        result = sampleOne <= sampleTwo;
        result = sampleOne >= sampleTwo;
    }

    private void ConcatConversionSample()
    {
        var sampleOne = false;
        var sampleTwo = true;
        var result = false;

        result = (bool)sampleOne;
        result = sampleOne && sampleTwo;
        result = sampleOne || sampleTwo;
    }

    private void CompundAssignmenntSample()
    {
        var sampleOne = 0;
        var sampleTwo = 1;
        var result = 0;

        result += sampleOne;
        result -= sampleOne;
        result *= sampleOne;
        result /= sampleOne;
        result %= sampleOne;
    }

    private void RangeSample()
    {
        var sampleList = new[] { 1, 2, 3, 4 };

        var range = sampleList[2..2];
    }
}