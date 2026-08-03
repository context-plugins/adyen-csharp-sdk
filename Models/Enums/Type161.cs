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
public sealed record Type161 : StringEnum<Type161>
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

    public static Type161 FromValue(string value) => FromValueCore(value);
}
