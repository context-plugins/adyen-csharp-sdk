using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ValuelinkInfo
{
    /// <summary>
    /// Authorisation Mid
    /// </summary>
    [JsonPropertyName("authorisationMid")]
    public required string AuthorisationMid { get; init; }

    /// <summary>
    /// PIN Support. For ecommerce, PIN is required.
    /// </summary>
    [JsonPropertyName("pinSupport")]
    public required PinSupport PinSupport { get; init; }

    /// <summary>
    /// Submitter ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("submitterId")]
    public string? SubmitterId { get; init; }

    /// <summary>
    /// Terminal ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("terminalId")]
    public string? TerminalId { get; init; }
}
