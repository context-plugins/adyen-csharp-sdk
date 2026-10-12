using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StoreAndForward
{
    /// <summary>
    /// The maximum amount that the terminal accepts for a single store-and-forward payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public IReadOnlyList<MinorUnitsMonetaryValue>? MaxAmount { get; init; }

    /// <summary>
    /// The maximum number of store-and-forward transactions per terminal that you can process while offline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxPayments")]
    public int? MaxPayments { get; init; }

    /// <summary>
    /// The type of card for which the terminal accepts store-and-forward payments. You can specify multiple card types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportedCardTypes")]
    public SupportedCardTypes2? SupportedCardTypes { get; init; }
}
