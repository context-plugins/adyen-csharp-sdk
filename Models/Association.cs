using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Association
{
    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    [JsonPropertyName("entityId")]
    [StringLength(100, MinimumLength = 1)]
    public required string EntityId { get; init; }

    [JsonPropertyName("entityType")]
    public required ScaEntityType1 EntityType { get; init; }

    /// <summary>
    /// The unique identifier for the SCA device.
    /// </summary>
    [JsonPropertyName("scaDeviceId")]
    [StringLength(30, MinimumLength = 30)]
    public required string ScaDeviceId { get; init; }

    [JsonPropertyName("status")]
    public required AssociationStatus1 Status { get; init; }
}
