using System.Text.Json.Serialization;

namespace GrpcServerProject
{
    public class Sampleparam
    {
        [JsonPropertyName(nameof(SampleProp))] public int SampleProp { get; set; }
    }
}