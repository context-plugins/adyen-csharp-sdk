using System;
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
public sealed record Type142 : OpenStringEnum<Type142>
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

    public TResult Match<TResult>(Func<TResult> onDefinedBeneficiary,
        Func<TResult> onDirector,
        Func<TResult> onImmediateParentCompany,
        Func<TResult> onLegalRepresentative,
        Func<TResult> onPciSignatory,
        Func<TResult> onProtector,
        Func<TResult> onSecondaryPartner,
        Func<TResult> onSecondaryTrustee,
        Func<TResult> onSettlor,
        Func<TResult> onSignatory,
        Func<TResult> onSoleProprietorship,
        Func<TResult> onTrust,
        Func<TResult> onTrustOwnership,
        Func<TResult> onUboThroughControl,
        Func<TResult> onUboThroughOwnership,
        Func<TResult> onUltimateParentCompany,
        Func<TResult> onUndefinedBeneficiary,
        Func<TResult> onUnincorporatedPartnership,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DefinedBeneficiary => onDefinedBeneficiary(),
            _ when this == Director => onDirector(),
            _ when this == ImmediateParentCompany => onImmediateParentCompany(),
            _ when this == LegalRepresentative => onLegalRepresentative(),
            _ when this == PciSignatory => onPciSignatory(),
            _ when this == Protector => onProtector(),
            _ when this == SecondaryPartner => onSecondaryPartner(),
            _ when this == SecondaryTrustee => onSecondaryTrustee(),
            _ when this == Settlor => onSettlor(),
            _ when this == Signatory => onSignatory(),
            _ when this == SoleProprietorship => onSoleProprietorship(),
            _ when this == Trust => onTrust(),
            _ when this == TrustOwnership => onTrustOwnership(),
            _ when this == UboThroughControl => onUboThroughControl(),
            _ when this == UboThroughOwnership => onUboThroughOwnership(),
            _ when this == UltimateParentCompany => onUltimateParentCompany(),
            _ when this == UndefinedBeneficiary => onUndefinedBeneficiary(),
            _ when this == UnincorporatedPartnership => onUnincorporatedPartnership(),
            _ => otherwise(Value)
        };

    public void Match(Action onDefinedBeneficiary,
        Action onDirector,
        Action onImmediateParentCompany,
        Action onLegalRepresentative,
        Action onPciSignatory,
        Action onProtector,
        Action onSecondaryPartner,
        Action onSecondaryTrustee,
        Action onSettlor,
        Action onSignatory,
        Action onSoleProprietorship,
        Action onTrust,
        Action onTrustOwnership,
        Action onUboThroughControl,
        Action onUboThroughOwnership,
        Action onUltimateParentCompany,
        Action onUndefinedBeneficiary,
        Action onUnincorporatedPartnership,
        Action<string> otherwise)
    {
        if (this == DefinedBeneficiary) onDefinedBeneficiary();
        else if (this == Director) onDirector();
        else if (this == ImmediateParentCompany) onImmediateParentCompany();
        else if (this == LegalRepresentative) onLegalRepresentative();
        else if (this == PciSignatory) onPciSignatory();
        else if (this == Protector) onProtector();
        else if (this == SecondaryPartner) onSecondaryPartner();
        else if (this == SecondaryTrustee) onSecondaryTrustee();
        else if (this == Settlor) onSettlor();
        else if (this == Signatory) onSignatory();
        else if (this == SoleProprietorship) onSoleProprietorship();
        else if (this == Trust) onTrust();
        else if (this == TrustOwnership) onTrustOwnership();
        else if (this == UboThroughControl) onUboThroughControl();
        else if (this == UboThroughOwnership) onUboThroughOwnership();
        else if (this == UltimateParentCompany) onUltimateParentCompany();
        else if (this == UndefinedBeneficiary) onUndefinedBeneficiary();
        else if (this == UnincorporatedPartnership) onUnincorporatedPartnership();
        else otherwise(Value);
    }
}
