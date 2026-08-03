using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdateSplitConfigurationRuleRequest
{
    /// <summary>
    /// The currency condition that defines whether the split logic applies.
    /// Its value must be a three-character <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The funding source of the payment method.
    /// <para>
    /// Possible values:
    /// * <b>credit</b>
    /// * <b>debit</b>
    /// * <b>prepaid</b>
    /// * <b>deferred_debit</b>
    /// * <b>charged</b>
    /// * <b>ANY</b>
    /// </para>
    /// </summary>
    [JsonPropertyName("fundingSource")]
    public required string FundingSource { get; init; }

    /// <summary>
    /// The payment method condition that defines whether the split logic applies.
    /// <para>
    /// Possible values:
    /// * <see href="https://docs.adyen.com/development-resources/paymentmethodvariant">Payment method variant</see>: Apply the split logic for a specific payment method.
    /// * <b>ANY</b>: Apply the split logic for all available payment methods.
    /// </para>
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public required string PaymentMethod { get; init; }

    /// <summary>
    /// The sales channel condition that defines whether the split logic applies.
    /// <para>
    /// Possible values:
    /// * <b>Ecommerce</b>: Online transactions where the cardholder is present.
    /// * <b>ContAuth</b>: Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer).
    /// * <b>Moto</b>: Mail-order and telephone-order transactions where the customer is in contact with the merchant via email or telephone.
    /// * <b>POS</b>: Point-of-sale transactions where the customer is physically present to make a payment using a secure payment terminal.
    /// * <b>ANY</b>: All sales channels.
    /// </para>
    /// </summary>
    [JsonPropertyName("shopperInteraction")]
    public required string ShopperInteraction { get; init; }
}
