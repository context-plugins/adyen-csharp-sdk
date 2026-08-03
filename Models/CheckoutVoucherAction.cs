using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CheckoutVoucherAction
{
    /// <summary>
    /// The voucher alternative reference code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("alternativeReference")]
    public string? AlternativeReference { get; init; }

    /// <summary>
    /// A collection institution number (store number) for Econtext Pay-Easy ATM.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("collectionInstitutionNumber")]
    public string? CollectionInstitutionNumber { get; init; }

    /// <summary>
    /// The URL to download the voucher.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("downloadUrl")]
    public string? DownloadUrl { get; init; }

    /// <summary>
    /// An entity number of Multibanco.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    /// <summary>
    /// The date time of the voucher expiry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiresAt")]
    public string? ExpiresAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initialAmount")]
    public InitialAmount? InitialAmount { get; init; }

    /// <summary>
    /// The URL to the detailed instructions to make payment using the voucher.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instructionsUrl")]
    public string? InstructionsUrl { get; init; }

    /// <summary>
    /// The issuer of the voucher.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuer")]
    public string? Issuer { get; init; }

    /// <summary>
    /// The shopper telephone number (partially masked).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maskedTelephoneNumber")]
    public string? MaskedTelephoneNumber { get; init; }

    /// <summary>
    /// The merchant name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantName")]
    public string? MerchantName { get; init; }

    /// <summary>
    /// The merchant reference.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// A Base64-encoded token containing all properties of the voucher. For iOS, you can use this to pass a voucher to Apple Wallet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("passCreationToken")]
    public string? PassCreationToken { get; init; }

    /// <summary>
    /// Encoded payment data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentData")]
    public string? PaymentData { get; init; }

    /// <summary>
    /// Specifies the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodType")]
    public string? PaymentMethodType { get; init; }

    /// <summary>
    /// The voucher reference code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The shopper email.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperEmail")]
    public string? ShopperEmail { get; init; }

    /// <summary>
    /// The shopper name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperName")]
    public string? ShopperName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("surcharge")]
    public Surcharge5? Surcharge { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    public TotalAmount2? TotalAmount { get; init; }

    /// <summary>
    /// <b>voucher</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type594 Type { get; init; }

    /// <summary>
    /// Specifies the URL to redirect to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}
