using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It contains: - the identification of the stored value accounts or the stored value cards, if provided by the Sale System, and - the associated products sold by the Sale System.
/// Data related to the stored value card.
/// </summary>
public record StoredValueData
{
    /// <summary>
    /// Identification of the provider of the stored value account load/reload.
    /// If more than one provider to manage on the POI, and StoredValueAccountID absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueProvider")]
    [RegularExpression("^.+$")]
    public string? StoredValueProvider { get; init; }

    [JsonPropertyName("StoredValueTransactionType")]
    public required StoredValueTransactionType1 StoredValueTransactionType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueAccountID")]
    public StoredValueAccountId2? StoredValueAccountId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OriginalPOITransaction")]
    public OriginalPoitransaction3? OriginalPoitransaction { get; init; }

    /// <summary>
    /// Product code of item purchased with the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProductCode")]
    [Minimum(1)]
    [Maximum(20)]
    public int? ProductCode { get; init; }

    /// <summary>
    /// Standard product code of item purchased with the transaction.
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
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Currency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public string? Currency { get; init; }
}
