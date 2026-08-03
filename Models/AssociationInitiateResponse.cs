using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AssociationInitiateResponse
{
    /// <summary>
    /// A string that you must pass to the authentication SDK to continue with the association process.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkInput")]
    [MaxLength(20000)]
    public string? SdkInput { get; init; }
}
