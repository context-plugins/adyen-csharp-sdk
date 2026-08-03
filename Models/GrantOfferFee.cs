using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantOfferFee
{
    [JsonPropertyName("amount")]
    public required Amount5 Amount { get; init; }

    /// <summary>
    /// Annual Percentage Rate (APR) of the offer. The percentage is expressed in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("aprBasisPoints")]
    public int? AprBasisPoints { get; init; }
}
