using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardReaderApduresponse1
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
