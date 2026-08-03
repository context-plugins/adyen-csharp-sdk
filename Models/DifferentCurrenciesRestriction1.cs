using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Compares the currency of the payment against the currency of the payment instrument, and specifies the operation.
/// <para>
/// Supported operations: <b>equals</b>, <b>notEquals</b>.
/// </para>
/// </summary>
public record DifferentCurrenciesRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// Checks the currency of the payment against the currency of the payment instrument.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>true</b>: The currency of the payment is different from the currency of the payment instrument.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>false</b>: The currencies are the same.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public bool? Value { get; init; }
}
