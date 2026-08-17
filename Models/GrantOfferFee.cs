using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantOfferFee
{
    /// <summary>
    /// Contains the amount of the offer fee.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Annual Percentage Rate (APR) of the offer. The percentage is expressed in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aprBasisPoints")]
    public int? AprBasisPoints { get; init; }
}
