using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransactionRuleEntityKey
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
