using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Mobile phone is used as a payment instrument for the transaction.
/// Information related to the mobile for the payment transaction.
/// </summary>
public record MobileData
{
    /// <summary>
    /// Identifies the country of a mobile phone operator.
    /// If data available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MobileCountryCode")]
    [Minimum(3)]
    [Maximum(3)]
    public int? MobileCountryCode { get; init; }

    /// <summary>
    /// Identifies the mobile phone operator inside a country.
    /// If data available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MobileNetworkCode")]
    [Minimum(2)]
    [Maximum(3)]
    public int? MobileNetworkCode { get; init; }

    /// <summary>
    /// Masked Mobile Subscriber Integrated Service Digital Network.
    /// If data available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaskedMSISDN")]
    public int? MaskedMsisdn { get; init; }

    /// <summary>
    /// Geographic location specified by geographic or UTM coordinates.
    /// If data available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Geolocation")]
    public Geolocation1? Geolocation { get; init; }

    /// <summary>
    /// Sensitive information related to the mobile phone, protected by CMS.
    /// SensitiveMobileData.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtectedMobileData")]
    public string? ProtectedMobileData { get; init; }

    /// <summary>
    /// Sensitive information related to the mobile phone.
    /// If unprotected mobile data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SensitiveMobileData")]
    public SensitiveMobileData1? SensitiveMobileData { get; init; }
}
