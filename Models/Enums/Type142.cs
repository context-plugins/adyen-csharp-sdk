using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Defines the relationship of the legal entity to the current legal entity.
/// <para>
/// Possible value for individuals: <b>legalRepresentative</b>.
/// </para>
/// <para>
/// Possible values for organizations: <b>director</b>, <b>signatory</b>, <b>trustOwnership</b>, <b>uboThroughOwnership</b>, <b>uboThroughControl</b>, <b>ultimateParentCompany</b>, or <b>immediateParentCompany</b>.
/// </para>
/// <para>
/// Possible values for sole proprietorships: <b>soleProprietorship</b>.
/// </para>
/// <para>
/// Possible value for trusts: <b>trust</b>.
/// </para>
/// <para>
/// Possible values for trust members: <b>definedBeneficiary</b>, <b>protector</b>, <b>secondaryTrustee</b>, <b>settlor</b>, <b>uboThroughControl</b>, or <b>uboThroughOwnership</b>.
/// </para>
/// <para>
/// Possible value for unincorporated partnership: <b>unincorporatedPartnership</b>.
/// </para>
/// <para>
/// Possible values for unincorporated partnership members: <b>secondaryPartner</b>, <b>uboThroughControl</b>, <b>uboThroughOwnership</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type142>))]
public sealed record Type142 : StringEnum<Type142>
{
    private Type142(string value) : base(value)
    {
    }

    public static readonly Type142 DefinedBeneficiary = new("definedBeneficiary");

    public static readonly Type142 Director = new("director");

    public static readonly Type142 ImmediateParentCompany = new("immediateParentCompany");

    public static readonly Type142 LegalRepresentative = new("legalRepresentative");

    public static readonly Type142 PciSignatory = new("pciSignatory");

    public static readonly Type142 Protector = new("protector");

    public static readonly Type142 SecondaryPartner = new("secondaryPartner");

    public static readonly Type142 SecondaryTrustee = new("secondaryTrustee");

    public static readonly Type142 Settlor = new("settlor");

    public static readonly Type142 Signatory = new("signatory");

    public static readonly Type142 SoleProprietorship = new("soleProprietorship");

    public static readonly Type142 Trust = new("trust");

    public static readonly Type142 TrustOwnership = new("trustOwnership");

    public static readonly Type142 UboThroughControl = new("uboThroughControl");

    public static readonly Type142 UboThroughOwnership = new("uboThroughOwnership");

    public static readonly Type142 UltimateParentCompany = new("ultimateParentCompany");

    public static readonly Type142 UndefinedBeneficiary = new("undefinedBeneficiary");

    public static readonly Type142 UnincorporatedPartnership = new("unincorporatedPartnership");

    public static Type142 FromValue(string value) => FromValueCore(value);
}
