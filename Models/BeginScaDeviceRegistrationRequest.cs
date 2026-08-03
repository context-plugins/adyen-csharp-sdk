using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BeginScaDeviceRegistrationRequest
{
    /// <summary>
    /// The name of the SCA device that you are registering. You can use it to help your users identify the device.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(64, MinimumLength = 0)]
    public required string Name { get; init; }

    /// <summary>
    /// A base64-encoded block with the data required to register the SCA device. You obtain this information by using Adyen's authentication SDK.
    /// </summary>
    [JsonPropertyName("sdkOutput")]
    [StringLength(20000, MinimumLength = 0)]
    public required string SdkOutput { get; init; }
}
