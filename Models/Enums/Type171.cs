using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of trust.
/// <para>
/// See possible values for trusts in <see href="https://docs.adyen.com/platforms/verification-requirements/?tab=trust_3_4#trust-types-in-australia">Australia</see> and <see href="https://docs.adyen.com/platforms/verification-requirements/?tab=trust_3_4#trust-types-in-new-zealand">New Zealand</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type171>))]
public sealed record Type171 : StringEnum<Type171>
{
    private Type171(string value) : base(value)
    {
    }

    public static readonly Type171 BusinessTrust = new("businessTrust");

    public static readonly Type171 CashManagementTrust = new("cashManagementTrust");

    public static readonly Type171 CharitableTrust = new("charitableTrust");

    public static readonly Type171 CorporateUnitTrust = new("corporateUnitTrust");

    public static readonly Type171 DeceasedEstate = new("deceasedEstate");

    public static readonly Type171 DiscretionaryTrust = new("discretionaryTrust");

    public static readonly Type171 DiscretionaryInvestmentTrust = new("discretionaryInvestmentTrust");

    public static readonly Type171 DiscretionaryServicesManagementTrust = new("discretionaryServicesManagementTrust");

    public static readonly Type171 DiscretionaryTradingTrust = new("discretionaryTradingTrust");

    public static readonly Type171 FamilyTrust = new("familyTrust");

    public static readonly Type171 FirstHomeSaverAccountsTrust = new("firstHomeSaverAccountsTrust");

    public static readonly Type171 FixedTrust = new("fixedTrust");

    public static readonly Type171 FixedUnitTrust = new("fixedUnitTrust");

    public static readonly Type171 HybridTrust = new("hybridTrust");

    public static readonly Type171 ListedPublicUnitTrust = new("listedPublicUnitTrust");

    public static readonly Type171 OtherTrust = new("otherTrust");

    public static readonly Type171 PooledSuperannuationTrust = new("pooledSuperannuationTrust");

    public static readonly Type171 PublicTradingTrust = new("publicTradingTrust");

    public static readonly Type171 UnlistedPublicUnitTrust = new("unlistedPublicUnitTrust");

    public static Type171 FromValue(string value) => FromValueCore(value);
}
