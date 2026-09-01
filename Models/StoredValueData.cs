using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
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

    /// <summary>
    /// Identification of operation to proceed on the stored value account or the stored value card.
    /// Possible values:
    /// * <b>Activate</b>
    /// * <b>Duplicate</b>
    /// * <b>Load</b>
    /// * <b>Reserve</b>
    /// * <b>Reverse</b>
    /// * <b>Unload</b>
    /// </summary>
    [JsonPropertyName("StoredValueTransactionType")]
    public required StoredValueTransactionType1 StoredValueTransactionType { get; init; }

    /// <summary>
    /// Identification of the stored value account or the stored value card.
    /// If the identification of the Stored Value account or card has been made by the Sale System before the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueAccountID")]
    public StoredValueAccountId1? StoredValueAccountId { get; init; }

    /// <summary>
    /// Identification of a previous POI transaction.
    /// If StoredValueTransactionType is Reverse or Duplicate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OriginalPOITransaction")]
    public OriginalPoiTransaction1? OriginalPoiTransaction { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
