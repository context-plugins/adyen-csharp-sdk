using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record MpiData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authenticationResponse")]
    public AuthenticationResponse? AuthenticationResponse { get; init; }

    /// <summary>
    /// The cardholder authentication value (base64 encoded, 20 bytes in a decoded form).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavv")]
    public string? Cavv { get; init; }

    /// <summary>
    /// The CAVV algorithm used. Include this only for 3D Secure 1.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavvAlgorithm")]
    public string? CavvAlgorithm { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("challengeCancel")]
    public ChallengeCancel? ChallengeCancel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("directoryResponse")]
    public DirectoryResponse? DirectoryResponse { get; init; }

    /// <summary>
    /// Supported for 3D Secure 2. The unique transaction identifier assigned by the Directory Server (DS) to identify a single transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dsTransID")]
    public string? DsTransId { get; init; }

    /// <summary>
    /// The electronic commerce indicator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eci")]
    public string? Eci { get; init; }

    /// <summary>
    /// Risk score calculated by Directory Server (DS). Required for Cartes Bancaires integrations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskScore")]
    public string? RiskScore { get; init; }

    /// <summary>
    /// The version of the 3D Secure protocol.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSVersion")]
    public string? ThreeDsversion { get; init; }

    /// <summary>
    /// Network token authentication verification value (TAVV). The network token cryptogram.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenAuthenticationVerificationValue")]
    public string? TokenAuthenticationVerificationValue { get; init; }

    /// <summary>
    /// Provides information on why the <c>transStatus</c> field has the specified value. For possible values, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/api-reference#possible-transstatusreason-values">our docs</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transStatusReason")]
    public string? TransStatusReason { get; init; }

    /// <summary>
    /// Supported for 3D Secure 1. The transaction identifier (Base64-encoded, 20 bytes in a decoded form).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("xid")]
    public string? Xid { get; init; }
}
