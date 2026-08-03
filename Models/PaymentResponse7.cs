using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentResponse7
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public PaymentValidationsNameResponse? Name { get; init; }
}
