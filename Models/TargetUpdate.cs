using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TargetUpdate
{
    /// <summary>
    /// The unique identifier of the <c>target.type</c>. This can be the ID of your:
    /// <list type="bullet">
    ///   <item><description>balance platform</description></item>
    ///   <item><description>account holder</description></item>
    ///   <item><description>account holder's balance account</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    [MinLength(1)]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type18? Type { get; init; }
}
