using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferInstrumentInfo
{
    [JsonPropertyName("bankAccount")]
    public required BankAccountInfo BankAccount { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id">legal entity</see> that owns the transfer instrument.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    public required string LegalEntityId { get; init; }

    [JsonPropertyName("type")]
    public required Type222 Type { get; init; }
}
