using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>maestro_usa</b>.
/// Only for Maestro USA, otherwise use <c>maestro</c>.
/// </summary>
public record GenericPmWithTdiUpdateInfo12
{
    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo1? TransactionDescription { get; init; }
}
