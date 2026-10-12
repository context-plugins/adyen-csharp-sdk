using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record CashOutInfoCounterparty
{
    /// <summary>
    /// The unique identifier of the counterparty transfer instrument.
    /// <para>
    /// If you do not provide this field, the cashout funds remain in the instructing balance account after the cashout transfer is settled.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentId")]
    public string? TransferInstrumentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
