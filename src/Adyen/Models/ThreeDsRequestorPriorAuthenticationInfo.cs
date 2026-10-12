using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information about how the 3DS Requestor authenticated the cardholder as part of a previous 3DS transaction.
/// </summary>
public record ThreeDsRequestorPriorAuthenticationInfo
{
    /// <summary>
    /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorAuthData")]
    public string? ThreeDsReqPriorAuthData { get; init; }

    /// <summary>
    /// Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values:
    /// * <b>01</b> — Frictionless authentication occurred by ACS.
    /// * <b>02</b> — Cardholder challenge occurred by ACS.
    /// * <b>03</b> — AVS verified.
    /// * <b>04</b> — Other issuer methods.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorAuthMethod")]
    public ThreeDsReqPriorAuthMethod? ThreeDsReqPriorAuthMethod { get; init; }

    /// <summary>
    /// Date and time in UTC of the prior cardholder authentication. Format: YYYYMMDDHHMM
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorAuthTimestamp")]
    [StringLength(12, MinimumLength = 12)]
    public string? ThreeDsReqPriorAuthTimestamp { get; init; }

    /// <summary>
    /// This data element provides additional information to the ACS to determine the best approach for handing a request. This data element contains an ACS Transaction ID for a prior authenticated transaction. For example, the first recurring transaction that was authenticated with the cardholder. Length: 30 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorRef")]
    [StringLength(36, MinimumLength = 36)]
    public string? ThreeDsReqPriorRef { get; init; }
}
