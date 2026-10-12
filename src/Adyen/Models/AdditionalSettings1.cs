using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Additional shopper and transaction information to be included in your <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes">standard webhooks</see>. Find out more about the available <see href="https://docs.adyen.com/development-resources/webhooks/additional-settings">additional settings</see>.
/// </summary>
public record AdditionalSettings1
{
    /// <summary>
    /// Object containing list of event codes for which the notification will be sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("includeEventCodes")]
    public IReadOnlyList<string>? IncludeEventCodes { get; init; }

    /// <summary>
    /// Object containing boolean key-value pairs. The key can be any <see href="https://docs.adyen.com/development-resources/webhooks/additional-settings">standard webhook additional setting</see>, and the value indicates if the setting is enabled.
    /// For example, <c>includeCaptureDelayHours</c>: <b>true</b> means the standard notifications you get will contain the number of hours remaining until the payment will be captured.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("properties")]
    public IReadOnlyDictionary<string, bool>? Properties { get; init; }
}
