using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SupportingEntityCapability
{
    /// <summary>
    /// Indicates whether the capability is allowed for the supporting entity.
    /// <para>
    /// If a capability is allowed for a supporting entity but not for the parent legal entity, this means the legal entity has other supporting entities that failed verification.
    /// </para>
    /// <para>
    /// <b>You can use the allowed supporting entity</b> regardless of the verification status of other supporting entities.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    /// <summary>
    /// Supporting entity reference
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Indicates whether the supporting entity capability is requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requested")]
    public bool? Requested { get; init; }

    /// <summary>
    /// The status of the verification checks for the capability of the supporting entity.
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
