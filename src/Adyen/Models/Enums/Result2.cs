using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The result of this operation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Result2>))]
public sealed record Result2 : OpenStringEnum<Result2>
{
    private Result2(string value) : base(value)
    {
    }

    public static readonly Result2 ActiveRecurringTokenExists = new("ACTIVE_RECURRING_TOKEN_EXISTS");

    public static readonly Result2 AlreadyProcessed = new("ALREADY_PROCESSED");

    public static readonly Result2 PaymentNotFound = new("PAYMENT_NOT_FOUND");

    public static readonly Result2 Success = new("SUCCESS");

    public TResult Match<TResult>(Func<TResult> onActiveRecurringTokenExists,
        Func<TResult> onAlreadyProcessed,
        Func<TResult> onPaymentNotFound,
        Func<TResult> onSuccess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ActiveRecurringTokenExists => onActiveRecurringTokenExists(),
            _ when this == AlreadyProcessed => onAlreadyProcessed(),
            _ when this == PaymentNotFound => onPaymentNotFound(),
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onActiveRecurringTokenExists,
        Action onAlreadyProcessed,
        Action onPaymentNotFound,
        Action onSuccess,
        Action<string> otherwise)
    {
        if (this == ActiveRecurringTokenExists) onActiveRecurringTokenExists();
        else if (this == AlreadyProcessed) onAlreadyProcessed();
        else if (this == PaymentNotFound) onPaymentNotFound();
        else if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
