using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RecurringDetail
{
    /// <summary>
    /// This field contains additional data, which may be returned in a particular response.
    /// <para>
    /// The additionalData object consists of entries, each of which includes the key and value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// The alias of the credit card number.
    /// <para>
    /// Applies only to recurring contracts storing credit card details
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alias")]
    public string? Alias { get; init; }

    /// <summary>
    /// The alias type of the credit card number.
    /// <para>
    /// Applies only to recurring contracts storing credit card details.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aliasType")]
    public string? AliasType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bank")]
    public Bank? Bank { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card6? Card { get; init; }

    /// <summary>
    /// Types of recurring contracts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contractTypes")]
    public IReadOnlyList<string>? ContractTypes { get; init; }

    /// <summary>
    /// The date when the recurring details were created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// The <c>pspReference</c> of the first recurring payment that created the recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstPspReference")]
    public string? FirstPspReference { get; init; }

    /// <summary>
    /// An optional descriptive name for this recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Returned in the response if you are not tokenizing with Adyen and are using the Merchant-initiated transactions (MIT) framework from Mastercard or Visa.
    /// <para>
    /// This contains either the Mastercard Trace ID or the Visa Transaction ID.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTxReference")]
    public string? NetworkTxReference { get; init; }

    /// <summary>
    /// The  type or sub-brand of a payment method used, e.g. Visa Debit, Visa Corporate, etc. For more information, refer to <see href="https://docs.adyen.com/development-resources/paymentmethodvariant">PaymentMethodVariant</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodVariant")]
    public string? PaymentMethodVariant { get; init; }

    /// <summary>
    /// The reference that uniquely identifies the recurring detail.
    /// </summary>
    [JsonPropertyName("recurringDetailReference")]
    public required string RecurringDetailReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName? ShopperName { get; init; }

    /// <summary>
    /// A shopper's social security number (only in countries where it is legal to collect).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("socialSecurityNumber")]
    public string? SocialSecurityNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenDetails")]
    public TokenDetails? TokenDetails { get; init; }

    /// <summary>
    /// The unique identifier for the transaction link, used for Mastercard recurring transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLinkId")]
    public string? TransactionLinkId { get; init; }

    /// <summary>
    /// The payment method, such as “mc", "visa", "ideal", "paypal".
    /// </summary>
    [JsonPropertyName("variant")]
    public required string Variant { get; init; }
}
