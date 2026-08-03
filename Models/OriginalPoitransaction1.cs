using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Identification of a previous POI transaction.
/// If StoredValueTransactionType is Reverse or Duplicate.
/// </summary>
public record OriginalPoitransaction1
{
    /// <summary>
    /// Identification of a Sale System for the NEXO SaletoPOI protocol.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleID")]
    [RegularExpression("^.+$")]
    public string? SaleId { get; init; }

    /// <summary>
    /// Identification of a payment terminal for the NEXO SaletoPOI protocol.
    /// If original transaction is coming from another POI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public string? Poiid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POITransactionID")]
    public PoitransactionId? PoitransactionId { get; init; }

    /// <summary>
    /// Indicates if the card data has to be retrieved from a previous transaction.
    /// </summary>
    [JsonPropertyName("ReuseCardDataFlag")]
    public bool? ReuseCardDataFlag { get; init; } = true;

    /// <summary>
    /// Code assigned to a transaction approval by the Acquirer.
    /// If referral.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ApprovalCode")]
    [RegularExpression("^.+$")]
    public string? ApprovalCode { get; init; }

    /// <summary>
    /// Identification of the Acquirer.
    /// Restrict to the Acquirer if present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerID")]
    public int? AcquirerId { get; init; }

    /// <summary>
    /// Value of an amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AmountValue")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? AmountValue { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostTransactionID")]
    public HostTransactionId? HostTransactionId { get; init; }
}
