using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PinChangeResponse
{
    /// <summary>
    /// The status of the request for PIN change.
    /// <para>
    /// Possible values: <b>completed</b>, <b>pending</b>, <b>unavailable</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status13 Status { get; init; }
}
