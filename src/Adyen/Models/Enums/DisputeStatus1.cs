using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the dispute.
/// <para>
/// When you create a dispute, you can only set the <c>status</c> to <b>draft</b>. When you update a dispute, you can set the <c>status</c> to <b>submitted</b> or <b>closed</b>.
/// </para>
/// <para>
/// Possible values: <b>draft</b>, <b>submitted</b>, <b>closed</b>, <b>won</b>, <b>chargeback</b>, <b>secondPresentment</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeStatus1>))]
public sealed record DisputeStatus1 : OpenStringEnum<DisputeStatus1>
{
    private DisputeStatus1(string value) : base(value)
    {
    }

    public static readonly DisputeStatus1 Draft = new("draft");

    public static readonly DisputeStatus1 Submitted = new("submitted");

    public static readonly DisputeStatus1 Chargeback = new("chargeback");

    public static readonly DisputeStatus1 SecondPresentment = new("secondPresentment");

    public static readonly DisputeStatus1 Won = new("won");

    public static readonly DisputeStatus1 Closed = new("closed");

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
