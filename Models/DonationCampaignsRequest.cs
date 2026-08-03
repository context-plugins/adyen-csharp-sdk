using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DonationCampaignsRequest
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes/">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Locale on the shopper interaction device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("locale")]
    public string? Locale { get; init; }

    /// <summary>
    /// Your merchant account identifier.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Required for Adyen for Platforms integrations if you are a platform model. This is your <see href="https://docs.adyen.com/api-explorer/Management/3/post/merchants/(merchantId">reference</see>/stores#request-reference) (on <see href="https://docs.adyen.com/platforms">balance platform</see>) or the <see href="https://docs.adyen.com/api-explorer/Account/latest/post/updateAccountHolder#request-accountHolderDetails-storeDetails-storeReference">storeReference</see> (in the <see href="https://docs.adyen.com/classic-platforms/processing-payments/route-payment-to-store/#route-a-payment-to-a-store">classic integration</see>) for the ecommerce or point-of-sale store that is processing the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }
}
