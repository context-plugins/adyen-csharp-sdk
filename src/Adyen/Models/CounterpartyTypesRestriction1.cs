using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains a list of counterparty types and how they must be evaluated.
/// <para>
/// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
/// </para>
/// <para>
/// Supported value inputs:
/// - <b>balanceAccount</b>
/// - <b>bankAccount</b>
/// - <b>card</b>
/// - <b>transferInstrument</b>
/// </para>
/// </summary>
public record CounterpartyTypesRestriction1
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// The list of counterparty types to be evaluated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<Value>? Value { get; init; }
}
