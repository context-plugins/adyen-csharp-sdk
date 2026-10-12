using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The resulting status of the return.
/// <para>
/// Possible values: <b>Authorised</b>, <b>Declined</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status62>))]
public sealed record Status62 : OpenStringEnum<Status62>
{
    private Status62(string value) : base(value)
    {
    }

    public static readonly Status62 Authorised = new("Authorised");

    public static readonly Status62 Declined = new("Declined");

    public TResult Match<TResult>(Func<TResult> onAuthorised,
        Func<TResult> onDeclined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Authorised => onAuthorised(),
            _ when this == Declined => onDeclined(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuthorised, Action onDeclined, Action<string> otherwise)
    {
        if (this == Authorised) onAuthorised();
        else if (this == Declined) onDeclined();
        else otherwise(Value);
    }
}
