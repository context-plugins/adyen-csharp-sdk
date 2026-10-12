using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The details about the counterparty that is funding the top-up.
/// </summary>
public record TopUpCounterparty1
{
    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> that is funding the top-up.
    /// </summary>
    [JsonPropertyName("transferInstrumentId")]
    public required string TransferInstrumentId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
