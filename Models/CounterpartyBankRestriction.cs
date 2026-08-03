using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CounterpartyBankRestriction
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// The list of counterparty bank institutions to be evaluated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<BankIdentification>? Value { get; init; }
}
