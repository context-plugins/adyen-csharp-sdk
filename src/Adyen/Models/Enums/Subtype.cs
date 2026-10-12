using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of flow to initiate.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Subtype>))]
public sealed record Subtype : OpenStringEnum<Subtype>
{
    private Subtype(string value) : base(value)
    {
    }

    public static readonly Subtype Express = new("express");

    public static readonly Subtype Redirect = new("redirect");

    public static readonly Subtype Sdk = new("sdk");

    public TResult Match<TResult>(Func<TResult> onExpress,
        Func<TResult> onRedirect,
        Func<TResult> onSdk,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Express => onExpress(),
            _ when this == Redirect => onRedirect(),
            _ when this == Sdk => onSdk(),
            _ => otherwise(Value)
        };

    public void Match(Action onExpress, Action onRedirect, Action onSdk, Action<string> otherwise)
    {
        if (this == Express) onExpress();
        else if (this == Redirect) onRedirect();
        else if (this == Sdk) onSdk();
        else otherwise(Value);
    }
}
