using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record BeginScaDeviceRegistrationResponse
{
    /// <summary>
    /// A resource that contains information about a device, including its unique ID, name, and type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaDevice")]
    public ScaDevice? ScaDevice { get; init; }

    /// <summary>
    /// A string that you must pass to the authentication SDK to continue with the registration process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkInput")]
    [MaxLength(20000)]
    public string? SdkInput { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
