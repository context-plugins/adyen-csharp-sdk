using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DeliveryMethod
{
    /// <summary>
    /// The cost of this delivery method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount24? Amount { get; init; }

    /// <summary>
    /// The name of the delivery method as shown to the shopper.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The reference of the delivery method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// If you display the PayPal lightbox with delivery methods, set to <b>true</b> for the delivery method that is selected. Only one delivery method can be selected at a time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("selected")]
    public bool? Selected { get; init; }

    /// <summary>
    /// The type of the delivery method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type21? Type { get; init; }
}
