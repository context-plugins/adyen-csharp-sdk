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
public sealed record BusinessType : StringEnum<BusinessType>
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

    public static BusinessType FromValue(string value) => FromValueCore(value);
}
