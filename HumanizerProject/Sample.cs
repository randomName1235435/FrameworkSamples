using Humanizer;

namespace HumanizerProject;

public class Sample
{
    private void SampleMethod()
    {
        var filesize = 10.Kilobytes();
        var bits = filesize.Bits;
        var bytes = filesize.Bytes;
        var kilobytes = filesize.Kilobytes;
        var megabytes = filesize.Megabytes;
        var gigabytes = filesize.Gigabytes;
        var terabytes = filesize.Terabytes;

        var twoTimes = kilobytes + terabytes;
    }
}