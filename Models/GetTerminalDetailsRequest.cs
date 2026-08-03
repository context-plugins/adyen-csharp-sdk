using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetTerminalDetailsRequest
{
    /// <summary>
    /// The unique terminal ID in the format <c>[Device model]-[Serial number]</c>.
    /// <para>
    /// For example, <b>V400m-324689776</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("terminal")]
    public required string Terminal { get; init; }
}
