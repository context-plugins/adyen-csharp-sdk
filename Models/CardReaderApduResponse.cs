using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Reader APDU Response message.
/// It contains the result of the requested service, APDU response sent by the chip of the card in response to the APDU request.
/// </summary>
public record CardReaderApduResponse
{
    /// <summary>
    /// Result of a message request processing.
    /// </summary>
    [JsonPropertyName("Response")]
    public required Response11 Response { get; init; }

    /// <summary>
    /// Data field of the APDU command (Lc + Data).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("APDUData")]
    [RegularExpression("^.+$")]
    public string? ApduData { get; init; }

    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2).
    /// </summary>
    [JsonPropertyName("CardStatusWords")]
    [RegularExpression("^.{2,2}$")]
    public required string CardStatusWords { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
