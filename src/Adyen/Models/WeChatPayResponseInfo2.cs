using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>wechatpay</b> details
/// </summary>
public record WeChatPayResponseInfo2
{
    /// <summary>
    /// The name of the contact person from merchant support.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contactPersonName")]
    public string? ContactPersonName { get; init; }

    /// <summary>
    /// The email address of merchant support.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }
}
