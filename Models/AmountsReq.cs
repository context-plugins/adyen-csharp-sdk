using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Various amounts related to the payment request from the Sale System.
/// </summary>
public record AmountsReq
{
    /// <summary>
    /// Currency of a monetary amount.
    /// </summary>
    [JsonPropertyName("Currency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public required string Currency { get; init; }

    /// <summary>
    /// Amount requested by the Sale for the payment.
    /// </summary>
    [JsonPropertyName("RequestedAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public required double RequestedAmount { get; init; }

    /// <summary>
    /// The cash-back part of the amount requested by the Sale for the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CashBackAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CashBackAmount { get; init; }

    /// <summary>
    /// Amount paid for a tip. Allow the printing of the tip on the receipt, and to qualify the tip part of the amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TipAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? TipAmount { get; init; }

    /// <summary>
    /// Amount already paid in case of split payment. Depending on the context, a split payment is either a split amount, or a split basket (required by some payment means as fleet cards). The PaidAmount is present when the split payment is a split
    ///      of the amount. Split of the basket involves two Sale Transactions, and does not have to be recognised by
    ///      the POI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaidAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? PaidAmount { get; init; }

    /// <summary>
    /// Minimum amount the Sale System is allowed to deliver for this payment. For the OneTimeReservation, when the maximum amount is unknown, the Sale System indicates the minimum amount it allows.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MinimumAmountToDeliver")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? MinimumAmountToDeliver { get; init; }

    /// <summary>
    /// Maximum amount which could be requested for cash-back to the Sale System. Allows the Cashier
    ///    to limit the amount value of cash-back to deliver to the Customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaximumCashBackAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? MaximumCashBackAmount { get; init; }

    /// <summary>
    /// Minimum amount of a split, which could be requested by a Customer.Allows the Merchant to limit the number of split requested by the Customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MinimumSplitAmount")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? MinimumSplitAmount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
