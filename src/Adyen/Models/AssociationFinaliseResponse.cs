using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AssociationFinaliseResponse
{
    /// <summary>
    /// The unique identifier of the SCA device you associated with a resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// The list of unique identifiers of the resources that you associated with the SCA device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ids")]
    public IReadOnlyList<string>? Ids { get; init; }

    /// <summary>
    /// The type of resource that you associated with the SCA device.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "PAYMENT_INSTRUMENT";
}
