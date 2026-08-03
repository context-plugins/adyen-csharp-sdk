using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>interac_card</b>.
/// </summary>
public record GenericPmWithTdiInfo7
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
