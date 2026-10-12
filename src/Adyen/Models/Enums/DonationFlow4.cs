using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The interaction flow for in-person donations: complete payment for the purchase and the donation in one go, or separately.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DonationFlow4>))]
public sealed record DonationFlow4 : OpenStringEnum<DonationFlow4>
{
    private DonationFlow4(string value) : base(value)
    {
    }

    public static readonly DonationFlow4 OneStep = new("oneStep");

    public static readonly DonationFlow4 TwoStep = new("twoStep");

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
