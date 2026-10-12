using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PaymentValidations
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name6? Name { get; init; }
}
