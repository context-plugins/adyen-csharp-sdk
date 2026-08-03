using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;

namespace Adyen.Models;

public record PatchableTopUpAmount
{
    /// <summary>
    /// The fixed amount with which you want to top up the balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fixed")]
    public Fixed1? Fixed { get; init; }

    /// <summary>
    /// The target balance for the balance account that the top-up must achieve.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("target")]
    public Target4? Target { get; init; }
}
