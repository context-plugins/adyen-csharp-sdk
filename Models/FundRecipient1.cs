using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// the person or entity receiving the money
/// </summary>
public record FundRecipient1
{
    /// <summary>
    /// The IBAN of the bank account where the funds are being transferred to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IBAN")]
    public string? Iban { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress")]
    public BillingAddress7? BillingAddress { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public CardDetails? PaymentMethod { get; init; }

    /// <summary>
    /// The email address of the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

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
    [StringLength(256, MinimumLength = 3)]
    public string? ShopperReference { get; init; }

    /// <summary>
    /// This is the <c>recurringDetailReference</c> returned in the response when you created the token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    [MaxLength(64)]
    public string? StoredPaymentMethodId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchant")]
    public SubMerchant1? SubMerchant { get; init; }

    /// <summary>
    /// The telephone number of the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("telephoneNumber")]
    public string? TelephoneNumber { get; init; }

    /// <summary>
    /// The unique identifier for the wallet the funds are being transferred to. You can use the shopper reference or any other identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletIdentifier")]
    public string? WalletIdentifier { get; init; }

    /// <summary>
    /// The tax identifier of the person receiving the funds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletOwnerTaxId")]
    public string? WalletOwnerTaxId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletPurpose")]
    public WalletPurpose? WalletPurpose { get; init; }
}
