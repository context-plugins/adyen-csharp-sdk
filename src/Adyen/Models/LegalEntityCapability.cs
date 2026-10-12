using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalEntityCapability
{
    /// <summary>
    /// Indicates whether the capability is allowed. Adyen sets this to <b>true</b> if the verification is successful.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    /// <summary>
    /// The capability level that is allowed for the legal entity.
    /// <para>
    /// Possible values: <b>notApplicable</b>, <b>low</b>, <b>medium</b>, <b>high</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedLevel")]
    public AllowedLevel? AllowedLevel { get; init; }

    /// <summary>
    /// The settings that are allowed for the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedSettings")]
    public CapabilitySettings11? AllowedSettings { get; init; }

    /// <summary>
    /// Indicates whether the capability is requested. To check whether the legal entity is permitted to use the capability, refer to the <c>allowed</c> field.
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
    public AllowedLevel? RequestedLevel { get; init; }

    /// <summary>
    /// The settings that are requested for the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestedSettings")]
    public CapabilitySettings21? RequestedSettings { get; init; }

    /// <summary>
    /// The capability status of transfer instruments associated with the legal entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstruments")]
    public IReadOnlyList<SupportingEntityCapability>? TransferInstruments { get; init; }

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
    public string? VerificationStatus { get; init; }
}
