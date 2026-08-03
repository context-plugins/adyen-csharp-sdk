using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Reader APDU Response message.
/// It contains the result of the requested service, APDU response sent by the chip of the card in response to the APDU request.
/// </summary>
public record CardReaderApduresponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    /// <summary>
    /// Data field of the APDU command (Lc + Data).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("APDUData")]
    [RegularExpression("^.+$")]
    public string? Apdudata { get; init; }

    /// <summary>
    /// Status of a smartcard response to a command (SW1-SW2).
    /// </summary>
    [JsonPropertyName("CardStatusWords")]
    [RegularExpression("^.{2,2}$")]
    public required string CardStatusWords { get; init; }
}
