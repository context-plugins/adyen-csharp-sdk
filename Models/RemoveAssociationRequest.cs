using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record RemoveAssociationRequest
{
    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    [JsonPropertyName("entityId")]
    [StringLength(100, MinimumLength = 1)]
    public required string EntityId { get; init; }

    [JsonPropertyName("entityType")]
    public required ScaEntityType3 EntityType { get; init; }

    /// <summary>
    /// A list of device ids associated with the entity that should be removed.
    /// </summary>
    [JsonPropertyName("scaDeviceIds")]
    [MinLength(0)]
    [MaxLength(5)]
    public required IReadOnlyList<string> ScaDeviceIds { get; init; }
}
