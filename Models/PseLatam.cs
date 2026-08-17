using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PseLatam
{
    /// <summary>
    /// The shopper's bank.
    /// </summary>
    [JsonPropertyName("bank")]
    public required string Bank { get; init; }

    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// The client type.
    /// </summary>
    [JsonPropertyName("clientType")]
    public required string ClientType { get; init; }

    /// <summary>
    /// The identification code.
    /// </summary>
    [JsonPropertyName("identification")]
    public required string Identification { get; init; }

    /// <summary>
    /// The identification type.
    /// </summary>
    [JsonPropertyName("identificationType")]
    public required string IdentificationType { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// The payment method type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type46? Type { get; init; }
}
