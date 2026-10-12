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

    /// <summary>
    /// Indicator informing the Access Control Server (ACS) and the Directory Server (DS) that the authentication has been cancelled. For possible values, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/api-reference#mpidata">3D Secure API reference</see>.
    /// </summary>
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

    /// <summary>
    /// Indicates the exemption type that was applied by the issuer to the authentication, if exemption applied.
    /// Allowed values:
    /// * <c>lowValue</c>
    /// * <c>secureCorporate</c>
    /// * <c>trustedBeneficiary</c>
    /// * <c>transactionRiskAnalysis</c>
    /// </summary>
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

    /// <summary>
    /// Indicates whether a challenge is requested for this transaction. Possible values:
    /// * <b>01</b> — No preference
    /// * <b>02</b> — No challenge requested
    /// * <b>03</b> — Challenge requested (3DS Requestor preference)
    /// * <b>04</b> — Challenge requested (Mandate)
    /// * <b>05</b> — No challenge (transactional risk analysis is already performed)
    /// * <b>06</b> — Data Only
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsRequestorChallengeInd? ThreeDsRequestorChallengeInd { get; init; }

    /// <summary>
    /// The <c>threeDSServerTransID</c> value as defined in the 3D Secure 2 specification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSServerTransID")]
    public string? ThreeDsServerTransId { get; init; }

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
