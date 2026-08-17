using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FinishScaDeviceRegistrationResponse
{
    /// <summary>
    /// A resource that contains information about a device, including its unique ID, name, and type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaDevice")]
    public ScaDevice? ScaDevice { get; init; }
}
