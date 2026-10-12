using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Network type for Terminal API details webhooks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkType2>))]
public sealed record NetworkType2 : OpenStringEnum<NetworkType2>
{
    private NetworkType2(string value) : base(value)
    {
    }

    public static readonly NetworkType2 Local = new("local");

    public static readonly NetworkType2 Public = new("public");

    public TResult Match<TResult>(Func<TResult> onLocal, Func<TResult> onPublic, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Local => onLocal(),
            _ when this == Public => onPublic(),
            _ => otherwise(Value)
        };

    public void Match(Action onLocal, Action onPublic, Action<string> otherwise)
    {
        if (this == Local) onLocal();
        else if (this == Public) onPublic();
        else otherwise(Value);
    }
}
