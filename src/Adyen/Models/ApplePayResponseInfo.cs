using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ApplePayResponseInfo
{
    /// <summary>
    /// The list of merchant domains.
    /// <para>
    /// For more information, see <see href="https://docs.adyen.com/payment-methods/apple-pay/web-drop-in?tab=adyen-certificate-live_1#going-live">Apple Pay documentation</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("domains")]
    public IReadOnlyList<string>? Domains { get; init; }
}
