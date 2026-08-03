using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AccountSupportingEntityCapability
{
    /// <summary>
    /// Indicates whether the supporting entity capability is allowed. Adyen sets this to <b>true</b> if the verification is successful and the account holder is permitted to use the capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowedLevel")]
    public AllowedLevel? AllowedLevel { get; init; }

    /// <summary>
    /// Indicates whether the capability is enabled. If <b>false</b>, the capability is temporarily disabled for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// The ID of the supporting entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

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
    [JsonPropertyName("verificationStatus")]
    public VerificationStatus? VerificationStatus { get; init; }
}
