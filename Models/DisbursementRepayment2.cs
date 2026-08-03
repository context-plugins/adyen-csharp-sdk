using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// Contains information about the basis points configured for repaying the disbursement.
/// </summary>
public record DisbursementRepayment2
{
    /// <summary>
    /// The percentage of your user's incoming net volume that is deducted for repaying the grant. The percentage expressed in <see href="https://www.investopedia.com/terms/b/basispoint.asp">basis points</see>.
    /// </summary>
    [JsonPropertyName("basisPoints")]
    [Minimum(0)]
    [Maximum(10000)]
    public required int BasisPoints { get; init; }

    [JsonPropertyName("updateDescription")]
    [StringLength(240, MinimumLength = 1)]
    public required string UpdateDescription { get; init; }
}
