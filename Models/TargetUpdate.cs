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

    /// <summary>
    /// The resource for which you want to receive notifications. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>balancePlatform</b>: receive notifications about balance changes in your entire balance platform.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>accountHolder</b>: receive notifications about balance changes of a specific user.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>balanceAccount</b>: receive notifications about balance changes in a specific balance account.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type181? Type { get; init; }
}
