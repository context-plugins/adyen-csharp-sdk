using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentResponse8
{
    /// <summary>
    /// The card brand that the shopper used to pay. Only returned if <c>paymentMethod.type</c> is <b>scheme</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public string? Brand { get; init; }

    /// <summary>
    /// The <c>paymentMethod.type</c> value used in the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
