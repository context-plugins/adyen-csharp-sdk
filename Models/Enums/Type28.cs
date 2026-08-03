using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>dragonpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type28>))]
public sealed record Type28 : StringEnum<Type28>
{
    private Type28(string value) : base(value)
    {
    }

    public static readonly Type28 DragonpayEbanking = new("dragonpay_ebanking");

    public static readonly Type28 DragonpayOtcBanking = new("dragonpay_otc_banking");

    public static readonly Type28 DragonpayOtcNonBanking = new("dragonpay_otc_non_banking");

    public static readonly Type28 DragonpayOtcPhilippines = new("dragonpay_otc_philippines");

    public static Type28 FromValue(string value) => FromValueCore(value);
}
