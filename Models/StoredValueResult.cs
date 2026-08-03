using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// For each stored value card loaded or reloaded, in the StoredValue response message.
/// Result of loading/reloading a stored value card.
/// </summary>
public record StoredValueResult
{
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueAccountStatus")]
    public StoredValueAccountStatus? StoredValueAccountStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostTransactionID")]
    public HostTransactionId? HostTransactionId { get; init; }
}
