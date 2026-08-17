using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information about how the 3DS Requestor authenticated the cardholder before or during the transaction
/// </summary>
public record ThreeDsRequestorAuthenticationInfo
{
    /// <summary>
    /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqAuthData")]
    public string? ThreeDsReqAuthData { get; init; }

    /// <summary>
    /// Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values:
    /// * <b>01</b> — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest).
    /// * <b>02</b> — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials.
    /// * <b>03</b> — Login to the cardholder account at the 3DS Requestor system using federated ID.
    /// * <b>04</b> — Login to the cardholder account at the 3DS Requestor system using issuer credentials.
    /// * <b>05</b> — Login to the cardholder account at the 3DS Requestor system using third-party authentication.
    /// * <b>06</b> — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqAuthMethod")]
    public ThreeDsReqAuthMethod? ThreeDsReqAuthMethod { get; init; }

    /// <summary>
    /// Date and time in UTC of the cardholder authentication. Format: YYYYMMDDHHMM
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqAuthTimestamp")]
    [StringLength(12, MinimumLength = 12)]
    public string? ThreeDsReqAuthTimestamp { get; init; }
}
