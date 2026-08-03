using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BeginScaDeviceRegistrationResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaDevice")]
    public ScaDevice1? ScaDevice { get; init; }

    /// <summary>
    /// A string that you must pass to the authentication SDK to continue with the registration process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkInput")]
    [MaxLength(20000)]
    public string? SdkInput { get; init; }
}
