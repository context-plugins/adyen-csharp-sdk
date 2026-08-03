using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains indicators whether the page should only collect information for specific <see href="https://docs.adyen.com/classic-platforms/verification-checks">KYC checks</see>. By default, the page collects information for all KYC checks that apply to the <see href="https://docs.adyen.com/classic-platforms/account-holders-and-accounts#legal-entity-types">legal entity type</see>.
/// </summary>
public record CollectInformation1
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
