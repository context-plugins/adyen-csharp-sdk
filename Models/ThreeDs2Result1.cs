using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Result of the 3D Secure 2 authentication.
/// </summary>
public record ThreeDs2Result1
{
    /// <summary>
    /// The <c>authenticationValue</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationValue")]
    public string? AuthenticationValue { get; init; }

    /// <summary>
    /// The algorithm used by the ACS to calculate the authentication value, only for Cartes Bancaires integrations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavvAlgorithm")]
    public string? CavvAlgorithm { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeCancel")]
    public ChallengeCancel? ChallengeCancel { get; init; }

    /// <summary>
    /// The <c>dsTransID</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dsTransID")]
    public string? DsTransId { get; init; }

    /// <summary>
    /// The <c>eci</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eci")]
    public string? Eci { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemptionIndicator")]
    public ExemptionIndicator? ExemptionIndicator { get; init; }

    /// <summary>
    /// The <c>messageVersion</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageVersion")]
    public string? MessageVersion { get; init; }

    /// <summary>
    /// Risk score calculated by Cartes Bancaires Directory Server (DS).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskScore")]
    public string? RiskScore { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsrequestorChallengeInd? ThreeDsrequestorChallengeInd { get; init; }

    /// <summary>
    /// The <c>threeDSServerTransID</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSServerTransID")]
    public string? ThreeDsserverTransId { get; init; }

    /// <summary>
    /// The <c>timestamp</c> value of the 3D Secure 2 authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; init; }

    /// <summary>
    /// The <c>transStatus</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transStatus")]
    public string? TransStatus { get; init; }

    /// <summary>
    /// Provides information on why the <c>transStatus</c> field has the specified value. For possible values, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values">our docs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transStatusReason")]
    public string? TransStatusReason { get; init; }

    /// <summary>
    /// The <c>whiteListStatus</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whiteListStatus")]
    public string? WhiteListStatus { get; init; }
}
