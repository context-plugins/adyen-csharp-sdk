using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Notification message. It informs about the outcome of the operation. Possible values:
/// * CREATED
/// * ALREADY_EXISTS
/// * ERROR
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreationResultCode>))]
public sealed record CreationResultCode : OpenStringEnum<CreationResultCode>
{
    private CreationResultCode(string value) : base(value)
    {
    }

    public static readonly CreationResultCode AlreadyExists = new("ALREADY_EXISTS");

    public static readonly CreationResultCode Created = new("CREATED");

    public static readonly CreationResultCode Error = new("ERROR");

    public TResult Match<TResult>(Func<TResult> onAlreadyExists,
        Func<TResult> onCreated,
        Func<TResult> onError,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AlreadyExists => onAlreadyExists(),
            _ when this == Created => onCreated(),
            _ when this == Error => onError(),
            _ => otherwise(Value)
        };

    public void Match(Action onAlreadyExists, Action onCreated, Action onError, Action<string> otherwise)
    {
        if (this == AlreadyExists) onAlreadyExists();
        else if (this == Created) onCreated();
        else if (this == Error) onError();
        else otherwise(Value);
    }
}
