using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ApplePayInfo
{
    /// <summary>
    /// The list of merchant domains. Maximum: 99 domains per request.
    /// <para>
    /// For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/web-drop-in?tab=adyen-certificate-live_1#going-live">Apple Pay documentation</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("domains")]
    public required IReadOnlyList<string> Domains { get; init; }
}
