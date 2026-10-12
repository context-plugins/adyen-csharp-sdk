using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisputeStatus>))]
public sealed record DisputeStatus : OpenStringEnum<DisputeStatus>
{
    private DisputeStatus(string value) : base(value)
    {
    }

    public static readonly DisputeStatus Draft = new("draft");

    public static readonly DisputeStatus Submitted = new("submitted");

    public static readonly DisputeStatus Chargeback = new("chargeback");

    public static readonly DisputeStatus SecondPresentment = new("secondPresentment");

    public static readonly DisputeStatus Won = new("won");

    public static readonly DisputeStatus Closed = new("closed");

    public TResult Match<TResult>(Func<TResult> onDraft,
        Func<TResult> onSubmitted,
        Func<TResult> onChargeback,
        Func<TResult> onSecondPresentment,
        Func<TResult> onWon,
        Func<TResult> onClosed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Draft => onDraft(),
            _ when this == Submitted => onSubmitted(),
            _ when this == Chargeback => onChargeback(),
            _ when this == SecondPresentment => onSecondPresentment(),
            _ when this == Won => onWon(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onDraft,
        Action onSubmitted,
        Action onChargeback,
        Action onSecondPresentment,
        Action onWon,
        Action onClosed,
        Action<string> otherwise)
    {
        if (this == Draft) onDraft();
        else if (this == Submitted) onSubmitted();
        else if (this == Chargeback) onChargeback();
        else if (this == SecondPresentment) onSecondPresentment();
        else if (this == Won) onWon();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}
