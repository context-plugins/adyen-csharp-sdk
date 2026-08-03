using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Additional data for merchants who don't use Adyen as the payment authorisation gateway.
/// </summary>
public record MerchantDetails2
{
    /// <summary>
    /// 2-letter ISO 3166 country code of the card acceptor location.
    /// &gt; This parameter is required for the merchants who don't use Adyen as the payment authorisation gateway.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    [StringLength(2, MinimumLength = 2)]
    public string? CountryCode { get; init; }

    /// <summary>
    /// If true, indicates that the merchant is enrolled in 3D Secure for the card network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enrolledIn3DSecure")]
    public bool? EnrolledIn3Dsecure { get; init; }

    /// <summary>
    /// The merchant category code (MCC) is a four-digit number which relates to a particular market segment. This code reflects the predominant activity that is conducted by the merchant.
    /// <para>
    /// The list of MCCs can be found <see href="https://en.wikipedia.org/wiki/Merchant_category_code">here</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mcc")]
    public string? Mcc { get; init; }
}
