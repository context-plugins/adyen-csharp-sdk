using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AssociationListing
{
    /// <summary>
    /// The date and time when the association was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

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
    /// The unique identifier of the SCA device.
    /// </summary>
    [JsonPropertyName("scaDeviceId")]
    [StringLength(30, MinimumLength = 30)]
    public required string ScaDeviceId { get; init; }

    /// <summary>
    /// The human-readable name for the SCA device that was registered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaDeviceName")]
    [StringLength(64, MinimumLength = 0)]
    public string? ScaDeviceName { get; init; }

    /// <summary>
    /// The type of the device.
    /// </summary>
    [JsonPropertyName("scaDeviceType")]
    public required ScaDeviceType3 ScaDeviceType { get; init; }

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
