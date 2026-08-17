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

    /// <summary>
    /// The type of the entity.
    /// <para>
    /// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("entityType")]
    public required ScaEntityType2 EntityType { get; init; }

    /// <summary>
    /// List of device ids associated to the entity that will be approved.
    /// </summary>
    [JsonPropertyName("scaDeviceIds")]
    [MinLength(0)]
    [MaxLength(5)]
    public required IReadOnlyList<string> ScaDeviceIds { get; init; }

    /// <summary>
    /// The status of the association.
    /// <para>
    /// Possible values: <b>active</b> or <b>pendingApproval</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required AssociationStatus1 Status { get; init; }
}
