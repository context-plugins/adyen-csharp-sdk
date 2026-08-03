using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record MobileData2
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Geolocation")]
    public Geolocation? Geolocation { get; init; }

    /// <summary>
    /// Sensitive information related to the mobile phone, protected by CMS.
    /// SensitiveMobileData.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtectedMobileData")]
    public string? ProtectedMobileData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SensitiveMobileData")]
    public SensitiveMobileData? SensitiveMobileData { get; init; }
}
