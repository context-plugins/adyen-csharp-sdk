using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record DisbursementRepaymentInfoUpdate
{
    /// <summary>
    /// The percentage of your user's incoming net volume that is deducted for repaying the grant. The percentage expressed in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("basisPoints")]
    [Minimum(0)]
    [Maximum(10000)]
    public int? BasisPoints { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updateDescription")]
    [StringLength(240, MinimumLength = 0)]
    public string? UpdateDescription { get; init; }
}
