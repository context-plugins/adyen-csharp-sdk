using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Card Reader APDU Request message.
/// </summary>
public record CardReaderApdurequest2
{
    /// <summary>
    /// Class field of the APDU command (CLA). APDU request for Card Reader device request. For specific card like synchronous card, a private value should be used in accordance to ISO 7816- 4 (private range D0-FE).
    /// </summary>
    [JsonPropertyName("APDUClass")]
    [RegularExpression("^.{1,1}$")]
    public required string Apduclass { get; init; }

    /// <summary>
    /// Instruction field of the APDU command (INS).
    /// </summary>
    [JsonPropertyName("APDUInstruction")]
    [RegularExpression("^.{1,1}$")]
    public required string Apduinstruction { get; init; }

    /// <summary>
    /// Parameter 1 field of the APDU command (P1).
    /// </summary>
    [JsonPropertyName("APDUPar1")]
    [RegularExpression("^.{1,1}$")]
    public required string Apdupar1 { get; init; }

    /// <summary>
    /// Parameter 2 field of the APDU command(P2).
    /// </summary>
    [JsonPropertyName("APDUPar2")]
    [RegularExpression("^.{1,1}$")]
    public required string Apdupar2 { get; init; }

    /// <summary>
    /// Data field of the APDU command (Lc + Data).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("APDUData")]
    [RegularExpression("^.+$")]
    public string? Apdudata { get; init; }

    /// <summary>
    /// Expected length of the data field of the APDU response to the command (Le).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("APDUExpectedLength")]
    [RegularExpression("^.{1,1}$")]
    public string? ApduexpectedLength { get; init; }
}
