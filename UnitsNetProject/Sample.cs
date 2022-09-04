using UnitsNet;

namespace UnitsNetProject;

public class Sample
{
    private void SampleMehod()
    {
        var filesize = Information.FromBytes(1_000_000);
        var bits = filesize.Bits;
        var bytes = filesize.Bytes;
        var kilobytes = filesize.Kilobytes;
        var megabytes = filesize.Megabytes;
        var gigabytes = filesize.Gigabytes;
        var terabytes = filesize.Terabytes;

        var twoTimes = kilobytes + terabytes;

        var l1 = 2 * Length.FromMeters(1);
        var l2 = Length.FromMeters(1) / 2;
        var l3 = l1 + l2;

        var distance = Speed.FromKilometersPerHour(80) * TimeSpan.FromMinutes(30);
    }
}