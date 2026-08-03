using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Recurring3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contract")]
    public Contract? Contract { get; init; }

    /// <summary>
    /// A descriptive name for this detail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringDetailName")]
    public string? RecurringDetailName { get; init; }

    /// <summary>
    /// Date after which no further authorisations shall be performed. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringExpiry")]
    public DateTimeOffset? RecurringExpiry { get; init; }

    /// <summary>
    /// Minimum number of days between authorisations. Only for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recurringFrequency")]
    public string? RecurringFrequency { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenService")]
    public TokenService? TokenService { get; init; }
}
