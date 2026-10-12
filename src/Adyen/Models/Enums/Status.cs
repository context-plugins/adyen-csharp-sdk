using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Informs you if the name validation was performed. Possible values:
/// <para>
/// <b>performed</b>, <b>notPerformed</b>, <b>notSupported</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : OpenStringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status NotPerformed = new("notPerformed");

    public static readonly Status NotSupported = new("notSupported");

    public static readonly Status Performed = new("performed");

    public TResult Match<TResult>(Func<TResult> onNotPerformed,
        Func<TResult> onNotSupported,
        Func<TResult> onPerformed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NotPerformed => onNotPerformed(),
            _ when this == NotSupported => onNotSupported(),
            _ when this == Performed => onPerformed(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotPerformed, Action onNotSupported, Action onPerformed, Action<string> otherwise)
    {
        if (this == NotPerformed) onNotPerformed();
        else if (this == NotSupported) onNotSupported();
        else if (this == Performed) onPerformed();
        else otherwise(Value);
    }
}
