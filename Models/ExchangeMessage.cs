using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ExchangeMessage
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageCode")]
    public string? MessageCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("messageDescription")]
    public string? MessageDescription { get; init; }
}
