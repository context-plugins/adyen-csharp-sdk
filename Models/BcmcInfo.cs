using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BcmcInfo
{
    /// <summary>
    /// Indicates if <see href="https://docs.adyen.com/payment-methods/bancontact/bancontact-mobile">Bancontact mobile</see> is enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableBcmcMobile")]
    public bool? EnableBcmcMobile { get; init; }
}
