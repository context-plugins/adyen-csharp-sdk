using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataSwish
{
    /// <summary>
    /// A Swish shopper's telephone number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("swish.payerAlias")]
    public string? SwishPayerAlias { get; init; }
}
