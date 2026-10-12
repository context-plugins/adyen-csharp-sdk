using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>jcb</b>.
/// For merchants operating in Japan, <c>midNumber</c>, <c>reuseMidNumber</c>, and <c>serviceLevel</c> fields are required.
/// For merchants operating outside of Japan, these fields are not required.
/// </summary>
public record GenericPmWithTdiUpdateInfo10
{
    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo1? TransactionDescription { get; init; }
}
