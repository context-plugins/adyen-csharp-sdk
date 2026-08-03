using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountHolderCapability
{
    /// <summary>
    /// Indicates whether the capability is allowed. Adyen sets this to <b>true</b> if the verification is successful and the account holder is permitted to use the capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedLevel")]
    public AllowedLevel? AllowedLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedSettings")]
    public CapabilitySettings? AllowedSettings { get; init; }

    /// <summary>
    /// Indicates whether the capability is enabled. If <b>false</b>, the capability is temporarily disabled for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// Contains verification errors and the actions that you can take to resolve them.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("problems")]
    public IReadOnlyList<CapabilityProblem>? Problems { get; init; }

    /// <summary>
    /// Indicates whether the capability is requested. To check whether the account holder is permitted to use the capability, refer to the <c>allowed</c> field.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requested")]
    public bool? Requested { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestedLevel")]
    public RequestedLevel? RequestedLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestedSettings")]
    public CapabilitySettings? RequestedSettings { get; init; }

    /// <summary>
    /// Contains the status of the transfer instruments associated with this capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstruments")]
    public IReadOnlyList<AccountSupportingEntityCapability>? TransferInstruments { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationStatus")]
    public VerificationStatus1? VerificationStatus { get; init; }
}
