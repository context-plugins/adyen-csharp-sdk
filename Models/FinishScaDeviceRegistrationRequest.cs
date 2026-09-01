using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record FinishScaDeviceRegistrationRequest
{
    /// <summary>
    /// A base64-encoded block with the data required to register the SCA device. You obtain this information by using Adyen's authentication SDK.
    /// </summary>
    [JsonPropertyName("sdkOutput")]
    [StringLength(20000, MinimumLength = 0)]
    public required string SdkOutput { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
