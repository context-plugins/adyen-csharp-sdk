using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The scope to which the transfer limit applies. Possible values:
/// * <b>perTransaction</b>: you set a maximum amount for each transfer made from the balance account or balance platform.
/// * <b>perDay</b>: you set a maximum total amount for all transfers made from the balance account or balance platform in a day.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Scope>))]
public sealed record Scope : OpenStringEnum<Scope>
{
    private Scope(string value) : base(value)
    {
    }

    public static readonly Scope PerDay = new("perDay");

    public static readonly Scope PerTransaction = new("perTransaction");

    public TResult Match<TResult>(Func<TResult> onPerDay,
        Func<TResult> onPerTransaction,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PerDay => onPerDay(),
            _ when this == PerTransaction => onPerTransaction(),
            _ => otherwise(Value)
        };

    public void Match(Action onPerDay, Action onPerTransaction, Action<string> otherwise)
    {
        if (this == PerDay) onPerDay();
        else if (this == PerTransaction) onPerTransaction();
        else otherwise(Value);
    }
}
