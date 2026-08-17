using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record VerificationError
{
    /// <summary>
    /// Contains the capabilities that the verification error applies to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyList<Capability>? Capabilities { get; init; }

    /// <summary>
    /// The verification error code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// A description of the error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Contains the actions that you can take to resolve the verification error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("remediatingActions")]
    public IReadOnlyList<RemediatingAction>? RemediatingActions { get; init; }

    /// <summary>
    /// Contains more granular information about the verification error.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subErrors")]
    public IReadOnlyList<VerificationErrorRecursive>? SubErrors { get; init; }

    /// <summary>
    /// The type of error.
    /// <para>
    ///
    /// </para>
    /// <para>
    /// Possible values:
    /// *  <b>invalidInput</b>
    /// *  <b>dataMissing</b>
    /// *  <b>pendingStatus</b>
    /// *  <b>dataReview</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type212? Type { get; init; }
}
