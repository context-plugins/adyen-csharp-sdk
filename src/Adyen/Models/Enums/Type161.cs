using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of organization.
/// <para>
/// Possible values: <b>associationIncorporated</b>, <b>governmentalOrganization</b>, <b>listedPublicCompany</b>, <b>nonProfit</b>, <b>partnershipIncorporated</b>, <b>privateCompany</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type161>))]
public sealed record Type161 : OpenStringEnum<Type161>
{
    private Type161(string value) : base(value)
    {
    }

    public static readonly Type161 AssociationIncorporated = new("associationIncorporated");

    public static readonly Type161 GovernmentalOrganization = new("governmentalOrganization");

    public static readonly Type161 ListedPublicCompany = new("listedPublicCompany");

    public static readonly Type161 NonProfit = new("nonProfit");

    public static readonly Type161 PartnershipIncorporated = new("partnershipIncorporated");

    public static readonly Type161 PrivateCompany = new("privateCompany");

    public TResult Match<TResult>(Func<TResult> onAssociationIncorporated,
        Func<TResult> onGovernmentalOrganization,
        Func<TResult> onListedPublicCompany,
        Func<TResult> onNonProfit,
        Func<TResult> onPartnershipIncorporated,
        Func<TResult> onPrivateCompany,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AssociationIncorporated => onAssociationIncorporated(),
            _ when this == GovernmentalOrganization => onGovernmentalOrganization(),
            _ when this == ListedPublicCompany => onListedPublicCompany(),
            _ when this == NonProfit => onNonProfit(),
            _ when this == PartnershipIncorporated => onPartnershipIncorporated(),
            _ when this == PrivateCompany => onPrivateCompany(),
            _ => otherwise(Value)
        };

    public void Match(Action onAssociationIncorporated,
        Action onGovernmentalOrganization,
        Action onListedPublicCompany,
        Action onNonProfit,
        Action onPartnershipIncorporated,
        Action onPrivateCompany,
        Action<string> otherwise)
    {
        if (this == AssociationIncorporated) onAssociationIncorporated();
        else if (this == GovernmentalOrganization) onGovernmentalOrganization();
        else if (this == ListedPublicCompany) onListedPublicCompany();
        else if (this == NonProfit) onNonProfit();
        else if (this == PartnershipIncorporated) onPartnershipIncorporated();
        else if (this == PrivateCompany) onPrivateCompany();
        else otherwise(Value);
    }
}
