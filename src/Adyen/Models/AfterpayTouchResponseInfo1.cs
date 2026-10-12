using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>afterpaytouch</b> details
/// </summary>
public record AfterpayTouchResponseInfo1
{
    /// <summary>
    /// Support Email
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportEmail")]
    public string? SupportEmail { get; init; }

    /// <summary>
    /// Support Url
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("supportUrl")]
    public string? SupportUrl { get; init; }
}
