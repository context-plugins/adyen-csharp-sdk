using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.
/// <list type="bullet">
///   <item><description>For <b>organization</b>, the <c>type</c> values can be <b>proofOfAddress</b>, <b>registrationDocument</b>, <b>vatDocument</b>, <b>proofOfOrganizationTaxInfo</b>, <b>proofOfOwnership</b>, <b>proofOfIndustry</b>, <b>proofOfSignatory</b>, <b>proofOfDirector</b>, or <b>proofOfFundingOrWealthSource</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <b>individual</b>, the <c>type</c> values can be <b>identityCard</b>, <b>driversLicense</b>, <b>passport</b>, <b>liveSelfie</b>, <b>proofOfNationalIdNumber</b>, <b>proofOfResidency</b>, <b>proofOfIndustry</b>, <b>proofOfIndividualTaxId</b>, <b>proofOfFundingOrWealthSource</b> or <b>proofOfRelationship</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <b>soleProprietorship</b>, the <c>type</c> values can be <b>constitutionalDocument</b>, <b>proofOfAddress</b>, or <b>proofOfIndustry</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <b>trust</b>, the <c>type</c> value is <b>constitutionalDocument</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <b>unincorporatedPartnership</b>, the <c>type</c> value is <b>constitutionalDocument</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Use <b>bankStatement</b> to upload documents for a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type84>))]
public sealed record Type84 : OpenStringEnum<Type84>
{
    private Type84(string value) : base(value)
    {
    }

    public static readonly Type84 BankStatement = new("bankStatement");

    public static readonly Type84 DriversLicense = new("driversLicense");

    public static readonly Type84 IdentityCard = new("identityCard");

    public static readonly Type84 NationalIdNumber = new("nationalIdNumber");

    public static readonly Type84 Passport = new("passport");

    public static readonly Type84 ProofOfAddress = new("proofOfAddress");

    public static readonly Type84 ProofOfNationalIdNumber = new("proofOfNationalIdNumber");

    public static readonly Type84 ProofOfResidency = new("proofOfResidency");

    public static readonly Type84 RegistrationDocument = new("registrationDocument");

    public static readonly Type84 VatDocument = new("vatDocument");

    public static readonly Type84 ProofOfOrganizationTaxInfo = new("proofOfOrganizationTaxInfo");

    public static readonly Type84 ProofOfIndividualTaxId = new("proofOfIndividualTaxId");

    public static readonly Type84 ProofOfOwnership = new("proofOfOwnership");

    public static readonly Type84 ProofOfSignatory = new("proofOfSignatory");

    public static readonly Type84 LiveSelfie = new("liveSelfie");

    public static readonly Type84 ProofOfIndustry = new("proofOfIndustry");

    public static readonly Type84 ConstitutionalDocument = new("constitutionalDocument");

    public static readonly Type84 ProofOfFundingOrWealthSource = new("proofOfFundingOrWealthSource");

    public static readonly Type84 ProofOfRelationship = new("proofOfRelationship");

    public static readonly Type84 ProofOfDirector = new("proofOfDirector");

    public TResult Match<TResult>(Func<TResult> onBankStatement,
        Func<TResult> onDriversLicense,
        Func<TResult> onIdentityCard,
        Func<TResult> onNationalIdNumber,
        Func<TResult> onPassport,
        Func<TResult> onProofOfAddress,
        Func<TResult> onProofOfNationalIdNumber,
        Func<TResult> onProofOfResidency,
        Func<TResult> onRegistrationDocument,
        Func<TResult> onVatDocument,
        Func<TResult> onProofOfOrganizationTaxInfo,
        Func<TResult> onProofOfIndividualTaxId,
        Func<TResult> onProofOfOwnership,
        Func<TResult> onProofOfSignatory,
        Func<TResult> onLiveSelfie,
        Func<TResult> onProofOfIndustry,
        Func<TResult> onConstitutionalDocument,
        Func<TResult> onProofOfFundingOrWealthSource,
        Func<TResult> onProofOfRelationship,
        Func<TResult> onProofOfDirector,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankStatement => onBankStatement(),
            _ when this == DriversLicense => onDriversLicense(),
            _ when this == IdentityCard => onIdentityCard(),
            _ when this == NationalIdNumber => onNationalIdNumber(),
            _ when this == Passport => onPassport(),
            _ when this == ProofOfAddress => onProofOfAddress(),
            _ when this == ProofOfNationalIdNumber => onProofOfNationalIdNumber(),
            _ when this == ProofOfResidency => onProofOfResidency(),
            _ when this == RegistrationDocument => onRegistrationDocument(),
            _ when this == VatDocument => onVatDocument(),
            _ when this == ProofOfOrganizationTaxInfo => onProofOfOrganizationTaxInfo(),
            _ when this == ProofOfIndividualTaxId => onProofOfIndividualTaxId(),
            _ when this == ProofOfOwnership => onProofOfOwnership(),
            _ when this == ProofOfSignatory => onProofOfSignatory(),
            _ when this == LiveSelfie => onLiveSelfie(),
            _ when this == ProofOfIndustry => onProofOfIndustry(),
            _ when this == ConstitutionalDocument => onConstitutionalDocument(),
            _ when this == ProofOfFundingOrWealthSource => onProofOfFundingOrWealthSource(),
            _ when this == ProofOfRelationship => onProofOfRelationship(),
            _ when this == ProofOfDirector => onProofOfDirector(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankStatement,
        Action onDriversLicense,
        Action onIdentityCard,
        Action onNationalIdNumber,
        Action onPassport,
        Action onProofOfAddress,
        Action onProofOfNationalIdNumber,
        Action onProofOfResidency,
        Action onRegistrationDocument,
        Action onVatDocument,
        Action onProofOfOrganizationTaxInfo,
        Action onProofOfIndividualTaxId,
        Action onProofOfOwnership,
        Action onProofOfSignatory,
        Action onLiveSelfie,
        Action onProofOfIndustry,
        Action onConstitutionalDocument,
        Action onProofOfFundingOrWealthSource,
        Action onProofOfRelationship,
        Action onProofOfDirector,
        Action<string> otherwise)
    {
        if (this == BankStatement) onBankStatement();
        else if (this == DriversLicense) onDriversLicense();
        else if (this == IdentityCard) onIdentityCard();
        else if (this == NationalIdNumber) onNationalIdNumber();
        else if (this == Passport) onPassport();
        else if (this == ProofOfAddress) onProofOfAddress();
        else if (this == ProofOfNationalIdNumber) onProofOfNationalIdNumber();
        else if (this == ProofOfResidency) onProofOfResidency();
        else if (this == RegistrationDocument) onRegistrationDocument();
        else if (this == VatDocument) onVatDocument();
        else if (this == ProofOfOrganizationTaxInfo) onProofOfOrganizationTaxInfo();
        else if (this == ProofOfIndividualTaxId) onProofOfIndividualTaxId();
        else if (this == ProofOfOwnership) onProofOfOwnership();
        else if (this == ProofOfSignatory) onProofOfSignatory();
        else if (this == LiveSelfie) onLiveSelfie();
        else if (this == ProofOfIndustry) onProofOfIndustry();
        else if (this == ConstitutionalDocument) onConstitutionalDocument();
        else if (this == ProofOfFundingOrWealthSource) onProofOfFundingOrWealthSource();
        else if (this == ProofOfRelationship) onProofOfRelationship();
        else if (this == ProofOfDirector) onProofOfDirector();
        else otherwise(Value);
    }
}
