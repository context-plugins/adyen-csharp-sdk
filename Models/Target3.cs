using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The resource about whose balance change you want to get notified.
/// </summary>
public record Target3
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
    [JsonPropertyName("type")]
    public required Type181 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
