using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>carnet</b>.
/// </summary>
public record CarnetInfo1
{
    /// <summary>
    /// Indicates whether to add the MCC acronym to the merchant name for Prosa acquirer in Mexico.
    /// When set to <b>true</b>, the MCC acronym is automatically appended to the merchant name.
    /// Default: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("addMccAcronym")]
    public bool? AddMccAcronym { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo1? TransactionDescription { get; init; }
}
