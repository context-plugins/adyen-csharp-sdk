using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record VerificationError1
{
    /// <summary>
    /// Contains key-value pairs that specify the actions that the legal entity can do in your platform. The key is a capability required for your integration. For example, <b>issueCard</b> for Issuing.The value is an object containing the settings for the capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyList<Capability>? Capabilities { get; init; }

    /// <summary>
    /// The general error code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The general error message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// An object containing possible solutions to fix a verification error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remediatingActions")]
    public IReadOnlyList<RemediatingAction>? RemediatingActions { get; init; }

    /// <summary>
    /// An array containing more granular information about the cause of the verification error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subErrors")]
    public IReadOnlyList<VerificationErrorRecursive1>? SubErrors { get; init; }

    /// <summary>
    /// The type of error.
    /// <para>
    /// Possible values:
    /// *  <b>invalidInput</b>
    /// *  <b>dataMissing</b>
    /// *  <b>pendingStatus</b>
    /// *  <b>rejected</b>
    /// *  <b>dataReview</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type512? Type { get; init; }
}
