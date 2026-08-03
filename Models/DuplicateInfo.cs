using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DuplicateInfo
{
    /// <summary>
    /// The transaction id associated with the duplicate charge for which you are disputing. The disputed transaction must be in the same amount as the duplicate transaction.
    /// </summary>
    [JsonPropertyName("duplicateTransactionId")]
    [MinLength(1)]
    public required string DuplicateTransactionId { get; init; }

    /// <summary>
    /// The duplicate charge was made on the same card. Possible values: <b>true</b>, <b>false</b>.
    /// </summary>
    [JsonPropertyName("sameCard")]
    public required bool SameCard { get; init; }

    /// <summary>
    /// The issuer associated with each charge is the same. Possible values: <b>true</b>, <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameIssuer")]
    public bool? SameIssuer { get; init; }
}
