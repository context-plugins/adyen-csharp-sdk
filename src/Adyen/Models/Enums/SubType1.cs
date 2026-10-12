using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<SubType1>))]
public sealed record SubType1 : OpenStringEnum<SubType1>
{
    private SubType1(string value) : base(value)
    {
    }

    public static readonly SubType1 AtmDispute = new("atmDispute");

    public static readonly SubType1 CancelledGoodsServices = new("cancelledGoodsServices");

    public static readonly SubType1 CancelledRecurring = new("cancelledRecurring");

    public static readonly SubType1 CreditNotProcessed = new("creditNotProcessed");

    public static readonly SubType1 Counterfeit = new("counterfeit");

    public static readonly SubType1 NotAsDescribed = new("notAsDescribed");

    public TResult Match<TResult>(Func<TResult> onAtmDispute,
        Func<TResult> onCancelledGoodsServices,
        Func<TResult> onCancelledRecurring,
        Func<TResult> onCreditNotProcessed,
        Func<TResult> onCounterfeit,
        Func<TResult> onNotAsDescribed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AtmDispute => onAtmDispute(),
            _ when this == CancelledGoodsServices => onCancelledGoodsServices(),
            _ when this == CancelledRecurring => onCancelledRecurring(),
            _ when this == CreditNotProcessed => onCreditNotProcessed(),
            _ when this == Counterfeit => onCounterfeit(),
            _ when this == NotAsDescribed => onNotAsDescribed(),
            _ => otherwise(Value)
        };

    public void Match(Action onAtmDispute,
        Action onCancelledGoodsServices,
        Action onCancelledRecurring,
        Action onCreditNotProcessed,
        Action onCounterfeit,
        Action onNotAsDescribed,
        Action<string> otherwise)
    {
        if (this == AtmDispute) onAtmDispute();
        else if (this == CancelledGoodsServices) onCancelledGoodsServices();
        else if (this == CancelledRecurring) onCancelledRecurring();
        else if (this == CreditNotProcessed) onCreditNotProcessed();
        else if (this == Counterfeit) onCounterfeit();
        else if (this == NotAsDescribed) onNotAsDescribed();
        else otherwise(Value);
    }
}
