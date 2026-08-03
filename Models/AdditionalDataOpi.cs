using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataOpi
{
    /// <summary>
    /// Optional boolean indicator. Set to <b>true</b> if you want an ecommerce transaction to return an <c>opi.transToken</c> as additional data in the response.
    /// <para>
    /// You can store this Oracle Payment Interface token in your Oracle Opera database. For more information and required settings, see <see href="https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce">Oracle Opera</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("opi.includeTransToken")]
    public string? OpiIncludeTransToken { get; init; }
}
