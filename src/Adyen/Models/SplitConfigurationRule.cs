using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SplitConfigurationRule
{
    /// <summary>
    /// The card region condition that determines whether the <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">split logic</see>/splitConfigurations#request-rules-splitLogic) applies to the transaction.
    /// <para>
    /// &gt; This condition is in pilot phase, and not yet available for all platforms.
    /// </para>
    /// <para>
    /// Possible values:
    /// * <b>domestic</b>: The card issuer and the store where the transaction is processed are registered in the same country.
    /// * <b>international</b>: The card issuer and the store where the transaction is processed are registered in different countries or regions. Includes all <b>interRegional</b> and <b>intraRegional</b> transactions.
    /// * <b>interRegional</b>: The card issuer and the store where the transaction is processed are registered in different regions.
    /// * <b>intraRegional</b>: The card issuer and the store where the transaction is processed are registered in different countries, but in the same region.
    /// * <b>intraEEA</b>: The card issuer and the store where the transaction is processed are registered in different countries, but in the European Economic Area (EEA).
    /// * <b>ANY</b>: Applies to all transactions, regardless of the processing and issuing country/region.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardRegion")]
    public CardRegion? CardRegion { get; init; }

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
    public required FundingSource1 FundingSource { get; init; }

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
    /// The unique identifier of the split configuration rule.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ruleId")]
    public string? RuleId { get; init; }

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
    public required ShopperInteraction11 ShopperInteraction { get; init; }

    /// <summary>
    /// Contains the split logic that is applied if the rule conditions are met.
    /// </summary>
    [JsonPropertyName("splitLogic")]
    public required SplitConfigurationLogic2 SplitLogic { get; init; }
}
