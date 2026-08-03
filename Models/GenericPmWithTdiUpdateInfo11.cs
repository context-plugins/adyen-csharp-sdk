using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>maestro</b>.
/// In the US, <c>maestro</c> is not supported; use <c>maestro_usa</c> instead.
/// </summary>
public record GenericPmWithTdiUpdateInfo11
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
