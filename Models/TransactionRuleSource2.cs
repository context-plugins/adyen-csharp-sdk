using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the resource to which the transaction rule applies.
/// </summary>
public record TransactionRuleSource2
{
    /// <summary>
    /// ID of the resource, when applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Indicates the type of resource for which the transaction rule is defined.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>PaymentInstrumentGroup</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>PaymentInstrument</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>BalancePlatform</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>EntityUsageConfiguration</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>PlatformRule</b>: The transaction rule is a platform-wide rule imposed by Adyen.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
