using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>dragonpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type28>))]
public sealed record Type28 : OpenStringEnum<Type28>
{
    private Type28(string value) : base(value)
    {
    }

    public static readonly Type28 DragonpayEbanking = new("dragonpay_ebanking");

    public static readonly Type28 DragonpayOtcBanking = new("dragonpay_otc_banking");

    public static readonly Type28 DragonpayOtcNonBanking = new("dragonpay_otc_non_banking");

    public static readonly Type28 DragonpayOtcPhilippines = new("dragonpay_otc_philippines");

    public TResult Match<TResult>(Func<TResult> onDragonpayEbanking,
        Func<TResult> onDragonpayOtcBanking,
        Func<TResult> onDragonpayOtcNonBanking,
        Func<TResult> onDragonpayOtcPhilippines,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DragonpayEbanking => onDragonpayEbanking(),
            _ when this == DragonpayOtcBanking => onDragonpayOtcBanking(),
            _ when this == DragonpayOtcNonBanking => onDragonpayOtcNonBanking(),
            _ when this == DragonpayOtcPhilippines => onDragonpayOtcPhilippines(),
            _ => otherwise(Value)
        };

    public void Match(Action onDragonpayEbanking,
        Action onDragonpayOtcBanking,
        Action onDragonpayOtcNonBanking,
        Action onDragonpayOtcPhilippines,
        Action<string> otherwise)
    {
        if (this == DragonpayEbanking) onDragonpayEbanking();
        else if (this == DragonpayOtcBanking) onDragonpayOtcBanking();
        else if (this == DragonpayOtcNonBanking) onDragonpayOtcNonBanking();
        else if (this == DragonpayOtcPhilippines) onDragonpayOtcPhilippines();
        else otherwise(Value);
    }
}
