using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OnboardingLinkSettings
{
    /// <summary>
    /// The list of countries the user can choose from in hosted onboarding when <c>editPrefilledCountry</c> is allowed.
    /// <para>
    /// The value must be in the two-character <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code format.
    /// </para>
    /// <para>
    /// The array is empty by default, allowing all <see href="https://docs.adyen.com/platforms/onboard-users/#hosted-onboarding">countries and regions supported by hosted onboarding</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptedCountries")]
    public IReadOnlyList<string>? AcceptedCountries { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if the user can select the format for their payout account (if applicable).
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowBankAccountFormatSelection")]
    public bool? AllowBankAccountFormatSelection { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates whether the debug user interface (UI) is enabled. The debug UI provides information for your support staff to diagnose and resolve user issues during onboarding. It can be accessed using a keyboard shortcut.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowDebugUi")]
    public bool? AllowDebugUi { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if the user can select a payout account in a different EU/EEA location (including Switzerland and the UK) than the location of their legal entity.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowIntraRegionCrossBorderPayout")]
    public bool? AllowIntraRegionCrossBorderPayout { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates if the user can change their legal entity type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("changeLegalEntityType")]
    public bool? ChangeLegalEntityType { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates if the user can change the country of their legal entity's address, for example the registered address of an organization.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("editPrefilledCountry")]
    public bool? EditPrefilledCountry { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if only users above the age of 18 can be onboarded.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enforceLegalAge")]
    public bool? EnforceLegalAge { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates whether the introduction screen is hidden for the user of the individual legal entity type.
    /// The introduction screen provides brief instructions for the subsequent steps in the hosted onboarding process.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hideOnboardingIntroductionIndividual")]
    public bool? HideOnboardingIntroductionIndividual { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates whether the introduction screen is hidden for the user of the organization legal entity type.
    /// The introduction screen provides brief instructions for the subsequent steps in the hosted onboarding process.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hideOnboardingIntroductionOrganization")]
    public bool? HideOnboardingIntroductionOrganization { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates whether the introduction screen is hidden for the user of the sole proprietorship legal entity type.
    /// The introduction screen provides brief instructions for the subsequent steps in the hosted onboarding process.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hideOnboardingIntroductionSoleProprietor")]
    public bool? HideOnboardingIntroductionSoleProprietor { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates whether the introduction screen is hidden for the user of the trust legal entity type.
    /// The introduction screen provides brief instructions for the subsequent steps in the hosted onboarding process.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hideOnboardingIntroductionTrust")]
    public bool? HideOnboardingIntroductionTrust { get; init; }

    /// <summary>
    /// Default value: <b>true</b>
    /// <para>
    /// Indicates if the user can initiate the verification process through open banking providers, like Plaid or Tink.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instantBankVerification")]
    public bool? InstantBankVerification { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if the user is required to sign a PCI questionnaires for the <b>ecomMoto</b> sales channel type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirePciSignEcomMoto")]
    public bool? RequirePciSignEcomMoto { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if the user is required to sign a PCI questionnaires for the <b>eCommerce</b> sales channel type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirePciSignEcommerce")]
    public bool? RequirePciSignEcommerce { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if the user is required to sign a PCI questionnaires for the <b>pos</b> sales channel type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirePciSignPos")]
    public bool? RequirePciSignPos { get; init; }

    /// <summary>
    /// Default value: <b>false</b>
    /// <para>
    /// Indicates if the user is required to sign a PCI questionnaires for the <b>posMoto</b> sales channel type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requirePciSignPosMoto")]
    public bool? RequirePciSignPosMoto { get; init; }

    /// <summary>
    /// The maximum number of transfer instruments the user can create.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transferInstrumentLimit")]
    public int? TransferInstrumentLimit { get; init; }
}
