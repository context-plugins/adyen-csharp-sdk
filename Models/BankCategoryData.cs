using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BankCategoryData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public Priority? Priority { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type312? Type { get; init; }
}
