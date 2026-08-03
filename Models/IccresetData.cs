using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IccresetData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ATRValue")]
    [RegularExpression("^.{1,100}$")]
    public string? Atrvalue { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardStatusWords")]
    [RegularExpression("^.{2,2}$")]
    public string? CardStatusWords { get; init; }
}
