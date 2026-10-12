using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UndefinedBeneficiary
{
    /// <summary>
    /// The details of the undefined beneficiary.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The reference of the undefined beneficiary.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }
}
