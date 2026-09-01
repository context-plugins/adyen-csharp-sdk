using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// For each stored value card loaded or reloaded, in the StoredValue response message.
/// Result of loading/reloading a stored value card.
/// </summary>
public record StoredValueResult
{
    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// Copy.
    /// Possible values:
    /// * <b>Activate</b>
    /// * <b>Duplicate</b>
    /// * <b>Load</b>
    /// * <b>Reserve</b>
    /// * <b>Reverse</b>
    /// * <b>Unload</b>
    /// </summary>
    [JsonPropertyName("StoredValueTransactionType")]
    public required StoredValueTransactionType2 StoredValueTransactionType { get; init; }

    /// <summary>
    /// Product code of item purchased with the transaction.
    /// Copy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProductCode")]
    [Minimum(1)]
    [Maximum(20)]
    public int? ProductCode { get; init; }

    /// <summary>
    /// Standard product code of item purchased with the transaction.
    /// Copy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EanUpc")]
    public int? EanUpc { get; init; }

    /// <summary>
    /// Total amount of the item line.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ItemAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? ItemAmount { get; init; }

    /// <summary>
    /// Currency of a monetary amount.
    /// Copy.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Currency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public string? Currency { get; init; }

    /// <summary>
    /// Data related to the result of the stored value card transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueAccountStatus")]
    public StoredValueAccountStatus1? StoredValueAccountStatus { get; init; }

    /// <summary>
    /// Identification of the transaction by the host in charge of the stored value transaction.
    /// If provided by the Host.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostTransactionID")]
    public TransactionIdType7? HostTransactionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
