using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Allowed authentication methods: Magswipe, Manual Entry.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthenticationMethod>))]
public sealed record AuthenticationMethod : OpenStringEnum<AuthenticationMethod>
{
    private AuthenticationMethod(string value) : base(value)
    {
    }

    public static readonly AuthenticationMethod Magswipe = new("MAGSWIPE");

    public static readonly AuthenticationMethod Mke = new("MKE");

    public TResult Match<TResult>(Func<TResult> onMagswipe, Func<TResult> onMke, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Magswipe => onMagswipe(),
            _ when this == Mke => onMke(),
            _ => otherwise(Value)
        };

    public void Match(Action onMagswipe, Action onMke, Action<string> otherwise)
    {
        if (this == Magswipe) onMagswipe();
        else if (this == Mke) onMke();
        else otherwise(Value);
    }
}
