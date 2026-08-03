using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The payment modification. Only applicable for <see href="https://docs.adyen.com/platforms/internal-fund-transfers/internal-transfer-webhooks/#returned-internal-transfer">returned internal transfers</see>.
/// </summary>
public record Modification2
{
    /// <summary>
    /// The direction of the money movement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("direction")]
    public string? Direction { get; init; }

    /// <summary>
    /// Our reference for the modification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Your reference for the modification, used internally within your platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status25? Status { get; init; }

    /// <summary>
    /// The type of transfer modification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
