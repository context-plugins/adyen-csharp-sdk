using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The interaction flow for in-person donations. Possible values:
/// <list type="bullet">
///   <item><description><b>oneStep</b>: The shopper presents their payment method for the payment and the donation in one go, after the donation.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>twoStep</b>: The shopper presents their payment method twice: after the payment and after the donation.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DonationFlow1>))]
public sealed record DonationFlow1 : OpenStringEnum<DonationFlow1>
{
    private DonationFlow1(string value) : base(value)
    {
    }

    public static readonly DonationFlow1 OneStep = new("oneStep");

    public static readonly DonationFlow1 TwoStep = new("twoStep");

    public TResult Match<TResult>(Func<TResult> onOneStep, Func<TResult> onTwoStep, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == OneStep => onOneStep(),
            _ when this == TwoStep => onTwoStep(),
            _ => otherwise(Value)
        };

    public void Match(Action onOneStep, Action onTwoStep, Action<string> otherwise)
    {
        if (this == OneStep) onOneStep();
        else if (this == TwoStep) onTwoStep();
        else otherwise(Value);
    }
}
