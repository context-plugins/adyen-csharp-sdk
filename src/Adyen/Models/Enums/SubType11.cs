using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The specific category of <b>other</b> dispute that you are raising.
/// <para>
/// Possible values: <b>atmDispute</b>, <b>cancelledGoodsServices</b>, <b>cancelledRecurring</b>, <b>counterfeit</b>, <b>creditNotProcessed</b>, <b>notAsDescribed</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SubType11>))]
public sealed record SubType11 : OpenStringEnum<SubType11>
{
    private SubType11(string value) : base(value)
    {
    }

    public static readonly SubType11 AtmDispute = new("atmDispute");

    public static readonly SubType11 CancelledGoodsServices = new("cancelledGoodsServices");

    public static readonly SubType11 CancelledRecurring = new("cancelledRecurring");

    public static readonly SubType11 CreditNotProcessed = new("creditNotProcessed");

    public static readonly SubType11 Counterfeit = new("counterfeit");

    public static readonly SubType11 NotAsDescribed = new("notAsDescribed");

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
