using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DonationFlow>))]
public sealed record DonationFlow : OpenStringEnum<DonationFlow>
{
    private DonationFlow(string value) : base(value)
    {
    }

    public static readonly DonationFlow OneStep = new("oneStep");

    public static readonly DonationFlow TwoStep = new("twoStep");

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
