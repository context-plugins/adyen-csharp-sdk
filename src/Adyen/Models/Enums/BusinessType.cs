using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The organization's business type.
/// <para>
/// Possible values: <b>other</b>, <b>listedPublicCompany</b>, <b>subsidiaryOfListedPublicCompany</b>, <b>governmentalOrganization</b>, <b>internationalOrganization</b>, <b>financialInstitution</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BusinessType>))]
public sealed record BusinessType : OpenStringEnum<BusinessType>
{
    private BusinessType(string value) : base(value)
    {
    }

    public static readonly BusinessType Other = new("other");

    public static readonly BusinessType ListedPublicCompany = new("listedPublicCompany");

    public static readonly BusinessType SubsidiaryOfListedPublicCompany = new("subsidiaryOfListedPublicCompany");

    public static readonly BusinessType GovernmentalOrganization = new("governmentalOrganization");

    public static readonly BusinessType InternationalOrganization = new("internationalOrganization");

    public static readonly BusinessType FinancialInstitution = new("financialInstitution");

    public TResult Match<TResult>(Func<TResult> onOther,
        Func<TResult> onListedPublicCompany,
        Func<TResult> onSubsidiaryOfListedPublicCompany,
        Func<TResult> onGovernmentalOrganization,
        Func<TResult> onInternationalOrganization,
        Func<TResult> onFinancialInstitution,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Other => onOther(),
            _ when this == ListedPublicCompany => onListedPublicCompany(),
            _ when this == SubsidiaryOfListedPublicCompany => onSubsidiaryOfListedPublicCompany(),
            _ when this == GovernmentalOrganization => onGovernmentalOrganization(),
            _ when this == InternationalOrganization => onInternationalOrganization(),
            _ when this == FinancialInstitution => onFinancialInstitution(),
            _ => otherwise(Value)
        };

    public void Match(Action onOther,
        Action onListedPublicCompany,
        Action onSubsidiaryOfListedPublicCompany,
        Action onGovernmentalOrganization,
        Action onInternationalOrganization,
        Action onFinancialInstitution,
        Action<string> otherwise)
    {
        if (this == Other) onOther();
        else if (this == ListedPublicCompany) onListedPublicCompany();
        else if (this == SubsidiaryOfListedPublicCompany) onSubsidiaryOfListedPublicCompany();
        else if (this == GovernmentalOrganization) onGovernmentalOrganization();
        else if (this == InternationalOrganization) onInternationalOrganization();
        else if (this == FinancialInstitution) onFinancialInstitution();
        else otherwise(Value);
    }
}
