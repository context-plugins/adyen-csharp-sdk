using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CostEstimateRequest
{
    /// <summary>
    /// The transaction amount used as a base for the cost estimation.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount Amount { get; init; }

    /// <summary>
    /// Assumptions made for the expected characteristics of the transaction, for which the charges are being estimated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assumptions")]
    public CostEstimateAssumptions1? Assumptions { get; init; }

    /// <summary>
    /// The card number (4-19 characters) for PCI compliant use cases. Do not use any separators.
    /// <para>
    /// &gt; Either the <c>cardNumber</c> or <c>encryptedCardNumber</c> field must be provided in a payment request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNumber")]
    [StringLength(19, MinimumLength = 4)]
    public string? CardNumber { get; init; }

    /// <summary>
    /// Encrypted data that stores card information for non PCI-compliant use cases. The encrypted data must be created with the Checkout Card Component or Secured Fields Component, and must contain the <c>encryptedCardNumber</c> field.
    /// <para>
    /// &gt; Either the <c>cardNumber</c> or <c>encryptedCardNumber</c> field must be provided in a payment request.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedCardNumber")]
    public string? EncryptedCardNumber { get; init; }

    /// <summary>
    /// The merchant account identifier you want to process the (transaction) request with.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Additional data for merchants who don't use Adyen as the payment authorisation gateway.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantDetails")]
    public MerchantDetails2? MerchantDetails { get; init; }

    /// <summary>
    /// The recurring settings for the payment. Use this property when you want to enable <see href="https://docs.adyen.com/online-payments/tokenization">recurring payments</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring")]
    public Recurring? Recurring { get; init; }

    /// <summary>
    /// The <c>recurringDetailReference</c> you want to use for this cost estimate. The value <c>LATEST</c> can be used to select the most recently stored recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedRecurringDetailReference")]
    public string? SelectedRecurringDetailReference { get; init; }

    /// <summary>
    /// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
    /// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
    /// <para>
    /// This field has the following possible values:
    /// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
    /// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
    /// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
    /// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction? ShopperInteraction { get; init; }

    /// <summary>
    /// Required for recurring payments.
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }
}
