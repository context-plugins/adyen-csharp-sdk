using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TopUpCounterparty
{
    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> that is funding the top-up.
    /// </summary>
    [JsonPropertyName("transferInstrumentId")]
    public required string TransferInstrumentId { get; init; }
}
