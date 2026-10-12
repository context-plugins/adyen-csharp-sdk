using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the app. Possible values:
/// * <c>processing</c>: the app is being signed and converted to a format that the terminal can handle.
/// * <c>error</c>: something went wrong. Check that the app matches the <see href="https://docs.adyen.com/point-of-sale/android-terminals/app-requirements">requirements</see>.
/// * <c>invalid</c>: there is something wrong with the APK file of the app.
/// * <c>ready</c>: the app has been signed and converted.
/// * <c>archived</c>: the app is no longer available.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status7>))]
public sealed record Status7 : OpenStringEnum<Status7>
{
    private Status7(string value) : base(value)
    {
    }

    public static readonly Status7 Archived = new("archived");

    public static readonly Status7 Error = new("error");

    public static readonly Status7 Invalid = new("invalid");

    public static readonly Status7 Processing = new("processing");

    public static readonly Status7 Ready = new("ready");

    public TResult Match<TResult>(Func<TResult> onArchived,
        Func<TResult> onError,
        Func<TResult> onInvalid,
        Func<TResult> onProcessing,
        Func<TResult> onReady,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Archived => onArchived(),
            _ when this == Error => onError(),
            _ when this == Invalid => onInvalid(),
            _ when this == Processing => onProcessing(),
            _ when this == Ready => onReady(),
            _ => otherwise(Value)
        };

    public void Match(Action onArchived,
        Action onError,
        Action onInvalid,
        Action onProcessing,
        Action onReady,
        Action<string> otherwise)
    {
        if (this == Archived) onArchived();
        else if (this == Error) onError();
        else if (this == Invalid) onInvalid();
        else if (this == Processing) onProcessing();
        else if (this == Ready) onReady();
        else otherwise(Value);
    }
}
