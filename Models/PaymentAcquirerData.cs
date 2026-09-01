using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Data related to the response from the payment Acquirer.
/// </summary>
public record PaymentAcquirerData
{
    /// <summary>
    /// Identification of the Acquirer.
    /// Identification of the Acquirer when the POI System is multi-acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerID")]
    public int? AcquirerId { get; init; }

    /// <summary>
    /// Identification of the Merchant for the Acquirer.
    /// </summary>
    [JsonPropertyName("MerchantID")]
    [RegularExpression("^.+$")]
    public required string MerchantId { get; init; }

    /// <summary>
    /// Identification of the POI for the payment Acquirer.
    /// </summary>
    [JsonPropertyName("AcquirerPOIID")]
    [RegularExpression("^.+$")]
    public required string AcquirerPoiid { get; init; }

    /// <summary>
    /// Identification of the Transaction for the Acquirer.
    /// If provided by the Acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerTransactionID")]
    public TransactionIdType6? AcquirerTransactionId { get; init; }

    /// <summary>
    /// Code assigned to a transaction approval by the Acquirer.
    /// If available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ApprovalCode")]
    [RegularExpression("^.+$")]
    public string? ApprovalCode { get; init; }

    /// <summary>
    /// Identifier of a reconciliation period with a payment or loyalty host. Allows the assignment of a transaction to the Acquirer reconciliation (or batch).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("HostReconciliationID")]
    [RegularExpression("^.+$")]
    public string? HostReconciliationId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
