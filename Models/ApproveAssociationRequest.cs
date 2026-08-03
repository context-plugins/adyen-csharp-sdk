using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ApproveAssociationRequest
{
    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    [JsonPropertyName("entityId")]
    [StringLength(100, MinimumLength = 1)]
    public required string EntityId { get; init; }

    [JsonPropertyName("entityType")]
    public required ScaEntityType2 EntityType { get; init; }

    /// <summary>
    /// List of device ids associated to the entity that will be approved.
    /// </summary>
    [JsonPropertyName("scaDeviceIds")]
    [MinLength(0)]
    [MaxLength(5)]
    public required IReadOnlyList<string> ScaDeviceIds { get; init; }

    [JsonPropertyName("status")]
    public required AssociationStatus1 Status { get; init; }
}
