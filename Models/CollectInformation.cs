using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CollectInformation
{
    /// <summary>
    /// Indicates whether <see href="https://docs.adyen.com/classic-platforms/verification-process/accepted-data-format/#bank-accounts">bank account details</see> must be collected. Default is <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankDetails")]
    public bool? BankDetails { get; init; }

    /// <summary>
    /// Indicates whether <see href="https://docs.adyen.com/classic-platforms/verification-process/accepted-data-format/#organizations">business details</see> must be collected. Default is <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDetails")]
    public bool? BusinessDetails { get; init; }

    /// <summary>
    /// Indicates whether <see href="https://docs.adyen.com/classic-platforms/verification-process/accepted-data-format/#individuals">individual details</see> must be collected. Default is <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("individualDetails")]
    public bool? IndividualDetails { get; init; }

    /// <summary>
    /// Indicates whether <see href="https://docs.adyen.com/classic-platforms/verification-checks/legal-arrangements">legal arrangement details</see> must be collected. Default is <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementDetails")]
    public bool? LegalArrangementDetails { get; init; }

    /// <summary>
    /// Indicates whether answers to a <see href="https://docs.adyen.com/classic-platforms/platforms-for-partners#onboard-partner-platform">PCI questionnaire</see> must be collected. Applies only to partner platforms. Default is <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pciQuestionnaire")]
    public bool? PciQuestionnaire { get; init; }

    /// <summary>
    /// Indicates whether <see href="https://docs.adyen.com/classic-platforms/verification-process/accepted-data-format/#individuals">shareholder details</see> must be collected. Defaults to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderDetails")]
    public bool? ShareholderDetails { get; init; }
}
