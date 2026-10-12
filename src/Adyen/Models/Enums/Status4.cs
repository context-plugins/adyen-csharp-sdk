using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the request. This indicates whether the order was successfully updated with PayPal.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : OpenStringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 Error = new("error");

    public static readonly Status4 Success = new("success");

    public TResult Match<TResult>(Func<TResult> onError, Func<TResult> onSuccess, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Error => onError(),
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onError, Action onSuccess, Action<string> otherwise)
    {
        if (this == Error) onError();
        else if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
