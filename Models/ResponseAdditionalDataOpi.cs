using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataOpi
{
    /// <summary>
    /// Returned in the response if you included <c>opi.includeTransToken: true</c> in an ecommerce payment request. This contains an Oracle Payment Interface token that you can store in your Oracle Opera database to identify tokenized ecommerce transactions. For more information and required settings, see <see href="https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce">Oracle Opera</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opi.transToken")]
    public string? OpiTransToken { get; init; }
}
