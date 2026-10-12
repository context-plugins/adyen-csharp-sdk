using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>afterpaytouch</b>.
/// </summary>
public record AfterpayTouchInfo1
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
    [JsonPropertyName("supportUrl")]
    public required string SupportUrl { get; init; }
}
