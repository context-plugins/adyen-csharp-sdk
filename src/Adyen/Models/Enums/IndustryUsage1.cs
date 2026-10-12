using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for the amount update. Possible values:
/// * <b>delayedCharge</b>
/// * <b>noShow</b>
/// * <b>installment</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IndustryUsage1>))]
public sealed record IndustryUsage1 : OpenStringEnum<IndustryUsage1>
{
    private IndustryUsage1(string value) : base(value)
    {
    }

    public static readonly IndustryUsage1 DelayedCharge = new("delayedCharge");

    public static readonly IndustryUsage1 Installment = new("installment");

    public static readonly IndustryUsage1 NoShow = new("noShow");

    public TResult Match<TResult>(Func<TResult> onDelayedCharge,
        Func<TResult> onInstallment,
        Func<TResult> onNoShow,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DelayedCharge => onDelayedCharge(),
            _ when this == Installment => onInstallment(),
            _ when this == NoShow => onNoShow(),
            _ => otherwise(Value)
        };

    public void Match(Action onDelayedCharge, Action onInstallment, Action onNoShow, Action<string> otherwise)
    {
        if (this == DelayedCharge) onDelayedCharge();
        else if (this == Installment) onInstallment();
        else if (this == NoShow) onNoShow();
        else otherwise(Value);
    }
}
