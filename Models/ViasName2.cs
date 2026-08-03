using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The name of the individual.
/// &gt;Make sure your account holder registers using the name shown on their Photo ID.
///  Maximum length: 80 characters
///  Cannot contain numbers. /n Cannot be empty.
/// </summary>
public record ViasName2
{
    /// <summary>
    /// The first name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firstName")]
    [MaxLength(80)]
    public string? FirstName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gender")]
    public Gender? Gender { get; init; }

    /// <summary>
    /// The name's infix, if applicable.
    /// &gt;A maximum length of twenty (20) characters is imposed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("infix")]
    [MaxLength(20)]
    public string? Infix { get; init; }

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastName")]
    [MaxLength(80)]
    public string? LastName { get; init; }
}
