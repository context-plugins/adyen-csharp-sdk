using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// In case of <see href="https://docs.adyen.com/online-payments/adjust-authorisation#adjust-authorisation">asynchronous authorisation adjustment</see>, this field denotes why the additional payment is made.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>NoShow</b>: An incremental charge is carried out because of a no-show for a guaranteed reservation.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>DelayedCharge</b>: An incremental charge is carried out to process an additional payment after the original services have been rendered and the respective payment has been processed.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IndustryUsage>))]
public sealed record IndustryUsage : OpenStringEnum<IndustryUsage>
{
    private IndustryUsage(string value) : base(value)
    {
    }

    public static readonly IndustryUsage NoShow = new("NoShow");

    public static readonly IndustryUsage DelayedCharge = new("DelayedCharge");

    public TResult Match<TResult>(Func<TResult> onNoShow,
        Func<TResult> onDelayedCharge,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoShow => onNoShow(),
            _ when this == DelayedCharge => onDelayedCharge(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoShow, Action onDelayedCharge, Action<string> otherwise)
    {
        if (this == NoShow) onNoShow();
        else if (this == DelayedCharge) onDelayedCharge();
        else otherwise(Value);
    }
}
