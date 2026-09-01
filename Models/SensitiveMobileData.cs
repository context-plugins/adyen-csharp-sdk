using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record SensitiveMobileData
{
    /// <summary>
    /// Mobile Subscriber Integrated Service Digital Network (i.e. mobile phone number of the SIM card). Country, National Destination Code, and Subscriber Number.
    /// </summary>
    [JsonPropertyName("MSISDN")]
    public required int Msisdn { get; init; }

    /// <summary>
    /// International Mobile Subscriber Identity. Unique number associated with the mobile phone user, containing the Mobile Country Code (MCC), the Mobile Network Code (MNC), and the Mobile Identification Number (MSIN)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IMSI")]
    public int? Imsi { get; init; }

    /// <summary>
    /// International Mobile Equipment Identity. Unique number associated with the mobile phone device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IMEI")]
    public int? Imei { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
