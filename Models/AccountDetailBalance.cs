using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountDetailBalance
{
    /// <summary>
    /// The code of the account that holds the balance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("detailBalance")]
    public DetailBalance? DetailBalance { get; init; }
}
