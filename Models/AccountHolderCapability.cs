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

    /// <summary>
    /// The capability level that is allowed for the account holder.
    /// <para>
    /// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedLevel")]
    public AllowedLevel? AllowedLevel { get; init; }

    /// <summary>
    /// A JSON object containing the settings that are allowed for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedSettings")]
    public CapabilitySettings3? AllowedSettings { get; init; }

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

    /// <summary>
    /// The requested level of the capability. Some capabilities, such as those used in <see href="https://docs.adyen.com/issuing/add-capabilities#capability-levels">card issuing</see>, have different levels. Levels increase the capability, but also require additional checks and increased monitoring.
    /// <para>
    /// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestedLevel")]
    public RequestedLevel? RequestedLevel { get; init; }

    /// <summary>
    /// A JSON object containing the settings that were requested for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestedSettings")]
    public CapabilitySettings1? RequestedSettings { get; init; }

    /// <summary>
    /// Contains the status of the transfer instruments associated with this capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstruments")]
    public IReadOnlyList<AccountSupportingEntityCapability>? TransferInstruments { get; init; }

    /// <summary>
    /// The status of the verification checks for the capability.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>pending</b>: Adyen is running the verification.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>invalid</b>: The verification failed. Check if the <c>errors</c> array contains more information.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>valid</b>: The verification has been successfully completed.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>rejected</b>: Adyen has verified the information, but found reasons to not allow the capability.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationStatus")]
    public VerificationStatus? VerificationStatus { get; init; }
}
