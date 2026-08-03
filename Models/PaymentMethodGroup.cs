using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentMethodGroup
{
    /// <summary>
    /// The name of the group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Echo data to be used if the payment method is displayed as part of this group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethodData")]
    public string? PaymentMethodData { get; init; }

    /// <summary>
    /// The unique code of the group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
