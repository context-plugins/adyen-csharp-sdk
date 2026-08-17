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
public sealed record Type84 : StringEnum<Type84>
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

    public static Type84 FromValue(string value) => FromValueCore(value);
}
