using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataDomesticError
{
    /// <summary>
    /// The reason the transaction was declined, given by the local issuer.
    /// Currently available for merchants in Japan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domesticRefusalReasonRaw")]
    public string? DomesticRefusalReasonRaw { get; init; }

    /// <summary>
    /// The action the shopper should take, in a local language.
    /// Currently available in Japanese, for merchants in Japan.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domesticShopperAdvice")]
    public string? DomesticShopperAdvice { get; init; }
}
