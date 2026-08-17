using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// <b>valuelink</b> details
/// </summary>
public record ValuelinkResponseInfo2
{
    /// <summary>
    /// Authorisation Mid
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisationMid")]
    public string? AuthorisationMid { get; init; }

    /// <summary>
    /// PIN Support. For ecommerce, PIN is required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pinSupport")]
    public PinSupport? PinSupport { get; init; }

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
