using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// A resource that contains information about a device, including its unique ID, name, and type.
/// </summary>
public record ScaDevice
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

    /// <summary>
    /// Type of device registered.
    /// <para>
    /// Possible values: <b>ios</b>, <b>android</b>, <b>browser</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required ScaDeviceType1 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
