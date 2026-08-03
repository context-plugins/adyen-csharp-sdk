using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ThreeDsrequestorAuthenticationInfo1
{
    /// <summary>
    /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqAuthData")]
    public string? ThreeDsreqAuthData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqAuthMethod")]
    public ThreeDsreqAuthMethod? ThreeDsreqAuthMethod { get; init; }

    /// <summary>
    /// Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqAuthTimestamp")]
    [StringLength(12, MinimumLength = 12)]
    public string? ThreeDsreqAuthTimestamp { get; init; }
}
