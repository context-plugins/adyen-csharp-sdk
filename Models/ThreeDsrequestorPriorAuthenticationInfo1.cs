using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ThreeDsrequestorPriorAuthenticationInfo1
{
    /// <summary>
    /// Data that documents and supports a specific authentication process. Maximum length: 2048 bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorAuthData")]
    public string? ThreeDsreqPriorAuthData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorAuthMethod")]
    public ThreeDsreqPriorAuthMethod? ThreeDsreqPriorAuthMethod { get; init; }

    /// <summary>
    /// Date and time in UTC of the prior cardholder authentication. Format: YYYYMMDDHHMM
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorAuthTimestamp")]
    [StringLength(12, MinimumLength = 12)]
    public string? ThreeDsreqPriorAuthTimestamp { get; init; }

    /// <summary>
    /// This data element provides additional information to the ACS to determine the best approach for handing a request. This data element contains an ACS Transaction ID for a prior authenticated transaction. For example, the first recurring transaction that was authenticated with the cardholder. Length: 30 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSReqPriorRef")]
    [StringLength(36, MinimumLength = 36)]
    public string? ThreeDsreqPriorRef { get; init; }
}
