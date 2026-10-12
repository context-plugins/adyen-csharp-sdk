using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
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

    /// <summary>
    /// The type of entity you are associating the device with.
    /// <para>
    /// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("entityType")]
    public required ScaEntityType1 EntityType { get; init; }

    /// <summary>
    /// The unique identifier for the SCA device.
    /// </summary>
    [JsonPropertyName("scaDeviceId")]
    [StringLength(30, MinimumLength = 30)]
    public required string ScaDeviceId { get; init; }

    /// <summary>
    /// The status of the association.
    /// <para>
    /// Possible values: <b>active</b> or <b>pendingApproval</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required AssociationStatus1 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
