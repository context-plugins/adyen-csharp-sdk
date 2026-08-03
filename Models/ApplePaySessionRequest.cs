using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ApplePaySessionRequest
{
    /// <summary>
    /// This is the name that your shoppers will see in the Apple Pay interface.
    /// <para>
    /// The value returned as <c>configuration.merchantName</c> field from the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods"><c>/paymentMethods</c></see> response.
    /// </para>
    /// </summary>
    [JsonPropertyName("displayName")]
    [MaxLength(64)]
    public required string DisplayName { get; init; }

    /// <summary>
    /// The domain name you provided when you added Apple Pay in your Customer Area.
    /// <para>
    /// This must match the <c>window.location.hostname</c> of the web shop.
    /// </para>
    /// </summary>
    [JsonPropertyName("domainName")]
    public required string DomainName { get; init; }

    /// <summary>
    /// Your merchant identifier registered with Apple Pay.
    /// <para>
    /// Use the value of the <c>configuration.merchantId</c> field from the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/paymentMethods"><c>/paymentMethods</c></see> response.
    /// </para>
    /// </summary>
    [JsonPropertyName("merchantIdentifier")]
    public required string MerchantIdentifier { get; init; }
}
