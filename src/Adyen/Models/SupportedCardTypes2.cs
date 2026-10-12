using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The type of card for which the terminal accepts store-and-forward payments. You can specify multiple card types.
/// </summary>
public record SupportedCardTypes2
{
    /// <summary>
    /// Set to <b>true</b> to accept credit cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credit")]
    public bool? Credit { get; init; }

    /// <summary>
    /// Set to <b>true</b> to accept debit cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("debit")]
    public bool? Debit { get; init; }

    /// <summary>
    /// Set to <b>true</b> to accept cards that allow deferred debit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deferredDebit")]
    public bool? DeferredDebit { get; init; }

    /// <summary>
    /// Set to <b>true</b> to accept prepaid cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prepaid")]
    public bool? Prepaid { get; init; }

    /// <summary>
    /// Set to <b>true</b> to accept card types for which the terminal can't determine the funding source while offline.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("unknown")]
    public bool? Unknown { get; init; }
}
