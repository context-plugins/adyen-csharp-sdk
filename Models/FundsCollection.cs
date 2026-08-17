using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record FundsCollection
{
    /// <summary>
    /// Contains the identification information of the account to which you can transfer funds related to repayments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountIdentification")]
    public BankAccountIdentification1? AccountIdentification { get; init; }

    /// <summary>
    /// The type of funds collection.
    /// <para>
    /// Possible values: <b>UnscheduledRepayment</b>, <b>Revocation</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsCollectionType")]
    public FundsCollectionType2? FundsCollectionType { get; init; }
}
