using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CancelOrderResponse
{
    /// <summary>
    /// A unique reference of the cancellation request.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// The result of the cancellation request.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Received</b> – Indicates the cancellation has successfully been received by Adyen, and will be processed.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("resultCode")]
    public required ResultCode18 ResultCode { get; init; }
}
