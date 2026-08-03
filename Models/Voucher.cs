using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Voucher
{
    /// <summary>
    /// The checkout attempt identifier.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("checkoutAttemptId")]
    public string? CheckoutAttemptId { get; init; }

    /// <summary>
    /// The shopper's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The shopper's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required string LastName { get; init; }

    /// <summary>
    /// Base64-encoded JSON object containing SDK related parameters required by the SDK
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkData")]
    [MaxLength(50000)]
    public string? SdkData { get; init; }

    /// <summary>
    /// The shopper's email.
    /// </summary>
    [JsonPropertyName("shopperEmail")]
    public required string ShopperEmail { get; init; }

    /// <summary>
    /// The shopper's contact number. It must have an international number format, for example <b>+31 20 779 1846</b>. Formats like <b>+31 (0)20 779 1846</b> or <b>0031 20 779 1846</b> are not accepted.
    /// </summary>
    [JsonPropertyName("telephoneNumber")]
    public required string TelephoneNumber { get; init; }

    [JsonPropertyName("type")]
    public required Type29 Type { get; init; }
}
