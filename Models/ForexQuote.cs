using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ForexQuote
{
    /// <summary>
    /// The account name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account")]
    public string? Account { get; init; }

    /// <summary>
    /// The account type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public string? AccountType { get; init; }

    /// <summary>
    /// The base amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("baseAmount")]
    public Amount3? BaseAmount { get; init; }

    /// <summary>
    /// The base points.
    /// </summary>
    [JsonPropertyName("basePoints")]
    public required int BasePoints { get; init; }

    /// <summary>
    /// The buy rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy")]
    public Amount4? Buy { get; init; }

    /// <summary>
    /// The interbank amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interbank")]
    public Amount5? Interbank { get; init; }

    /// <summary>
    /// The reference assigned to the forex quote request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The sell rate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sell")]
    public Amount6? Sell { get; init; }

    /// <summary>
    /// The signature to validate the integrity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signature")]
    public string? Signature { get; init; }

    /// <summary>
    /// The source of the forex quote.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source")]
    public string? Source { get; init; }

    /// <summary>
    /// The type of forex.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The date until which the forex quote is valid.
    /// </summary>
    [JsonPropertyName("validTill")]
    public required DateTimeOffset ValidTill { get; init; }
}
