using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FinishScaDeviceRegistrationResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaDevice")]
    public ScaDevice1? ScaDevice { get; init; }
}
