using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardDetailsRequest
{
    /// <summary>
    /// A minimum of the first six digits of the card number. The full card number gives the best result.
    /// <para>
    /// You must be <see href="https://docs.adyen.com/development-resources/pci-dss-compliance-guide">fully PCI compliant</see> to collect raw card data. Alternatively, you can use the <c>encryptedCardNumber</c> field.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardNumber")]
    public string? CardNumber { get; init; }

    /// <summary>
    /// The shopper country code.
    /// <para>
    /// Format: <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see>
    /// Example: NL or DE
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The encrypted card number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("encryptedCardNumber")]
    [MaxLength(15000)]
    public string? EncryptedCardNumber { get; init; }

    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The card brands you support. This is the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/paymentMethods#responses-200-paymentMethods-brands"><c>brands</c></see> array from your <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods"><c>/paymentMethods</c></see> response.
    /// <para>
    /// If not included, our API uses the ones configured for your merchant account and, if provided, the country code.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportedBrands")]
    public IReadOnlyList<string>? SupportedBrands { get; init; }
}
