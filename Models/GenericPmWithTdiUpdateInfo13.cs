using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>mc</b>.
/// </summary>
public record GenericPmWithTdiUpdateInfo13
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
