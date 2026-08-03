using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information about the organization's publicly traded stock. Provide this object only if <c>type</c> is <b>listedPublicCompany</b>.
/// </summary>
public record StockData2
{
    /// <summary>
    /// The four-digit <see href="https://en.wikipedia.org/wiki/Market_Identifier_Code">Market Identifier Code</see> of the stock market where the organization's stocks are traded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("marketIdentifier")]
    public string? MarketIdentifier { get; init; }

    /// <summary>
    /// The 12-digit International Securities Identification Number (ISIN) of the company, without dashes (-).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stockNumber")]
    public string? StockNumber { get; init; }

    /// <summary>
    /// The stock ticker symbol.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tickerSymbol")]
    public string? TickerSymbol { get; init; }
}
