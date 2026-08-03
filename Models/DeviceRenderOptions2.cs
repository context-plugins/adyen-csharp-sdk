using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record DeviceRenderOptions2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkInterface")]
    public SdkInterface? SdkInterface { get; init; }

    /// <summary>
    /// UI types supported for displaying specific challenges.
    /// Allowed values:
    /// * text
    /// * singleSelect
    /// * outOfBand
    /// * otherHtml
    /// * multiSelect
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sdkUiType")]
    public IReadOnlyList<SdkUiType>? SdkUiType { get; init; }
}
