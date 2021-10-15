using System.Text.Json.Serialization;

public partial class Sampleparam
{
    [JsonPropertyName(nameof(SampleProp))]
    public int SampleProp { get; set; }
}