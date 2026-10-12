using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ConfigurationModel
{
    /// <summary>
    /// Payment method, like <b>eftpos_australia</b> or <b>mc</b>. See the <see href="https://docs.adyen.com/development-resources/paymentmethodvariant#management-api">possible values</see>.
    /// </summary>
    [JsonPropertyName("brand")]
    public required string Brand { get; init; }

    /// <summary>
    /// Set to <b>true</b> to apply surcharges only to commercial/business cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("commercial")]
    public bool? Commercial { get; init; }

    /// <summary>
    /// The country/region of the card issuer. If used, the surcharge settings only apply to the card issued in that country/region.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public IReadOnlyList<string>? Country { get; init; }

    /// <summary>
    /// Currency and percentage or amount of the surcharge.
    /// </summary>
    [JsonPropertyName("currencies")]
    public required IReadOnlyList<Currency> Currencies { get; init; }

    /// <summary>
    /// Funding source. Possible values:
    /// * <b>Credit</b>
    /// * <b>Debit</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sources")]
    public IReadOnlyList<string>? Sources { get; init; }
}
