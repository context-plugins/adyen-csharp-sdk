using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Result of the processing of the message.
/// Possible values:
/// * <b>Failure</b>
/// * <b>Partial</b>
/// * <b>Success</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result11>))]
public sealed record Result11 : OpenStringEnum<Result11>
{
    private Result11(string value) : base(value)
    {
    }

    public static readonly Result11 Success = new("Success");

    public static readonly Result11 Failure = new("Failure");

    public static readonly Result11 Partial = new("Partial");

    public TResult Match<TResult>(Func<TResult> onSuccess,
        Func<TResult> onFailure,
        Func<TResult> onPartial,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ when this == Partial => onPartial(),
            _ => otherwise(Value)
        };

    public void Match(Action onSuccess, Action onFailure, Action onPartial, Action<string> otherwise)
    {
        if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else if (this == Partial) onPartial();
        else otherwise(Value);
    }
}
