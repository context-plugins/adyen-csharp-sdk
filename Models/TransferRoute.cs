using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferRoute
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category2? Category { get; init; }

    /// <summary>
    /// The two-character ISO-3166-1 alpha-2 country code of the counterparty. For example, <b>US</b> or <b>NL</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    public string? Country { get; init; }

    /// <summary>
    /// The three-character ISO currency code of transfer. For example, <b>USD</b> or <b>EUR</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public Priority2? Priority { get; init; }

    /// <summary>
    /// A set of rules defined by clearing houses and banking partners. Your transfer request must adhere to these rules to ensure successful initiation of transfer. Based on the priority, one or more requirements may be returned. Each requirement is defined with a <c>type</c> and <c>description</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirements")]
    public IReadOnlyList<Requirement>? Requirements { get; init; }
}
