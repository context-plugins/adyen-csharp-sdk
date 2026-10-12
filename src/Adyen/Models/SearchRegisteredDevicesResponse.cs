using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SearchRegisteredDevicesResponse
{
    /// <summary>
    /// Contains a list of registered SCA devices and their corresponding details.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<Device>? Data { get; init; }

    /// <summary>
    /// The total amount of registered SCA devices that match the query parameters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemsTotal")]
    public int? ItemsTotal { get; init; }

    /// <summary>
    /// Contains links to the list pages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public Link1? Link { get; init; }

    /// <summary>
    /// The total amount of list pages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pagesTotal")]
    public int? PagesTotal { get; init; }
}
