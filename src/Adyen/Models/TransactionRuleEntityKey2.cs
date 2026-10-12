using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The type and unique identifier of the resource to which the rule applies.
/// </summary>
public record TransactionRuleEntityKey2
{
    /// <summary>
    /// The unique identifier of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityReference")]
    public string? EntityReference { get; init; }

    /// <summary>
    /// The type of resource.
    /// <para>
    /// Possible values: <b>balancePlatform</b>, <b>paymentInstrumentGroup</b>, <b>accountHolder</b>, <b>balanceAccount</b>, or <b>paymentInstrument</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entityType")]
    public string? EntityType { get; init; }
}
