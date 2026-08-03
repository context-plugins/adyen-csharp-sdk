using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TestCardRangeCreationResult
{
    /// <summary>
    /// The last test card number in the generated test card range.
    /// <para>
    /// Example: 5432 1234 1234 4321
    /// </para>
    /// </summary>
    [JsonPropertyName("cardNumberRangeEnd")]
    public required string CardNumberRangeEnd { get; init; }

    /// <summary>
    /// The first test card number in the generated test card range.
    /// <para>
    /// Example: 5432 1234 1234 1234
    /// </para>
    /// </summary>
    [JsonPropertyName("cardNumberRangeStart")]
    public required string CardNumberRangeStart { get; init; }

    [JsonPropertyName("creationResultCode")]
    public required CreationResultCode CreationResultCode { get; init; }

    /// <summary>
    /// An optional information message about the result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
