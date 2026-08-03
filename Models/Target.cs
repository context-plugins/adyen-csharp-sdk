using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Target
{
    /// <summary>
    /// The unique identifier of the <c>target.type</c>. This can be the ID of your:
    /// <list type="bullet">
    ///   <item><description>balance platform</description></item>
    ///   <item><description>account holder</description></item>
    ///   <item><description>account holder's balance account</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("id")]
    [MinLength(1)]
    public required string Id { get; init; }

    [JsonPropertyName("type")]
    public required Type18 Type { get; init; }
}
