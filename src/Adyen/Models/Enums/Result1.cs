using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Result of the validation. Ex: valid, invalid, unknown
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result1>))]
public sealed record Result1 : OpenStringEnum<Result1>
{
    private Result1(string value) : base(value)
    {
    }

    public static readonly Result1 Valid = new("VALID");

    public static readonly Result1 Invalid = new("INVALID");

    public static readonly Result1 Unknown = new("UNKNOWN");

    public static readonly Result1 NotRequired = new("NOT_REQUIRED");

    public TResult Match<TResult>(Func<TResult> onValid,
        Func<TResult> onInvalid,
        Func<TResult> onUnknown,
        Func<TResult> onNotRequired,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Valid => onValid(),
            _ when this == Invalid => onInvalid(),
            _ when this == Unknown => onUnknown(),
            _ when this == NotRequired => onNotRequired(),
            _ => otherwise(Value)
        };

    public void Match(Action onValid,
        Action onInvalid,
        Action onUnknown,
        Action onNotRequired,
        Action<string> otherwise)
    {
        if (this == Valid) onValid();
        else if (this == Invalid) onInvalid();
        else if (this == Unknown) onUnknown();
        else if (this == NotRequired) onNotRequired();
        else otherwise(Value);
    }
}
