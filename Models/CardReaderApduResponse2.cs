using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Reader APDU Response message.
/// </summary>
public record CardReaderApduResponse2
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
}
