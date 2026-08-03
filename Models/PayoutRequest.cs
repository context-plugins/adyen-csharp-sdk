using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayoutRequest
{
    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card6? Card { get; init; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudOffset")]
    public int? FraudOffset { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundSource")]
    public FundSource? FundSource { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurring")]
    public Recurring3? Recurring { get; init; }

    /// <summary>
    /// The reference to uniquely identify a payment. This reference is used in all communication with you about the payment status. We recommend using a unique value per payment; however, it is not a requirement.
    /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }

    /// <summary>
    /// The <c>recurringDetailReference</c> you want to use for this payment. The value <c>LATEST</c> can be used to select the most recently stored recurring detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selectedRecurringDetailReference")]
    public string? SelectedRecurringDetailReference { get; init; }

    /// <summary>
    /// The shopper's email address. We recommend that you provide this data, as it is used in velocity fraud checks. &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication if you did not include the <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperInteraction")]
    public ShopperInteraction1? ShopperInteraction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public ShopperName? ShopperName { get; init; }

    /// <summary>
    /// Required for recurring payments.
    /// Your reference to uniquely identify this shopper, for example user ID or account ID. The value is case-sensitive and must be at least three characters.
    /// &gt; Your reference must not include personally identifiable information (PII) such as name or email address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// The shopper's telephone number.
    ///  The phone number must include a plus sign (+) and a country code (1-3 digits), followed by the number (4-15 digits). If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }
}
