using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Indicates whether transaction is an international transaction and specifies the operation.
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>.
/// </para>
/// </summary>
public record InternationalTransactionRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// Boolean indicating whether transaction is an international transaction.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>true</b>: The transaction is an international transaction.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>false</b>: The transaction is a domestic transaction.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }
}
