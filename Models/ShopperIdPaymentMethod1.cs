using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// paymentMethod
/// </summary>
public record ShopperIdPaymentMethod1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
