using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BcmcResponseInfo
{
    /// <summary>
    /// Indicates if <see href="https://docs.adyen.com/payment-methods/bancontact/bancontact-mobile">Bancontact mobile</see> is enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableBcmcMobile")]
    public bool? EnableBcmcMobile { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
