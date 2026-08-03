using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TestWebhookResponse
{
    /// <summary>
    /// List with test results. Each test webhook we send has a list element with the result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<TestOutput>? Data { get; init; }
}
