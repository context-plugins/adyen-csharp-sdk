using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ScaDevice1
{
    /// <summary>
    /// The unique identifier of the SCA device you are registering.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The name of the SCA device that you are registering. You can use it to help your users identify the device.
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(64, MinimumLength = 0)]
    public required string Name { get; init; }

    [JsonPropertyName("type")]
    public required ScaDeviceType1 Type { get; init; }
}
