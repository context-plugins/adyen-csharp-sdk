using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The form of legal arrangement. Required if <c>type</c> is <b>Trust</b> or <b>Partnership</b>.
/// <para>
/// The possible values depend on the <c>type</c>.
/// </para>
/// <list type="bullet">
///   <item><description>For <c>type</c> <b>Trust</b>:  <b>CashManagementTrust</b>, <b>CorporateUnitTrust</b>, <b>DeceasedEstate</b>, <b>DiscretionaryInvestmentTrust</b>, <b>DiscretionaryServicesManagementTrust</b>, <b>DiscretionaryTradingTrust</b>, <b>FirstHomeSaverAccountsTrust</b>, <b>FixedTrust</b>, <b>FixedUnitTrust</b>, <b>HybridTrust</b>, <b>ListedPublicUnitTrust</b>, <b>OtherTrust</b>, <b>PooledSuperannuationTrust</b>, <b>PublicTradingTrust</b>, or <b>UnlistedPublicUnitTrust</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <c>type</c> <b>Partnership</b>: <b>LimitedPartnership</b>, <b>FamilyPartnership</b>, or <b>OtherPartnership</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalForm>))]
public sealed record LegalForm : StringEnum<LegalForm>
{
    private LegalForm(string value) : base(value)
    {
    }

    public static readonly LegalForm CashManagementTrust = new("CashManagementTrust");

    public static readonly LegalForm CorporateUnitTrust = new("CorporateUnitTrust");

    public static readonly LegalForm DeceasedEstate = new("DeceasedEstate");

    public static readonly LegalForm DiscretionaryInvestmentTrust = new("DiscretionaryInvestmentTrust");

    public static readonly LegalForm DiscretionaryServicesManagementTrust = new("DiscretionaryServicesManagementTrust");

    public static readonly LegalForm DiscretionaryTradingTrust = new("DiscretionaryTradingTrust");

    public static readonly LegalForm FirstHomeSaverAccountsTrust = new("FirstHomeSaverAccountsTrust");

    public static readonly LegalForm FixedTrust = new("FixedTrust");

    public static readonly LegalForm FixedUnitTrust = new("FixedUnitTrust");

    public static readonly LegalForm HybridTrust = new("HybridTrust");

    public static readonly LegalForm ListedPublicUnitTrust = new("ListedPublicUnitTrust");

    public static readonly LegalForm OtherTrust = new("OtherTrust");

    public static readonly LegalForm PooledSuperannuationTrust = new("PooledSuperannuationTrust");

    public static readonly LegalForm PublicTradingTrust = new("PublicTradingTrust");

    public static readonly LegalForm UnlistedPublicUnitTrust = new("UnlistedPublicUnitTrust");

    public static readonly LegalForm LimitedPartnership = new("LimitedPartnership");

    public static readonly LegalForm FamilyPartnership = new("FamilyPartnership");

    public static readonly LegalForm OtherPartnership = new("OtherPartnership");

    public static LegalForm FromValue(string value) => FromValueCore(value);
}
