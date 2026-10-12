using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Network type for Terminal API notification webhooks. Possible values:
/// * <b>public</b>
/// * <b>local</b>
/// <para>
/// Default Value: <b>public</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkType>))]
public sealed record NetworkType : OpenStringEnum<NetworkType>
{
    private NetworkType(string value) : base(value)
    {
    }

    public static readonly NetworkType Local = new("local");

    public static readonly NetworkType Public = new("public");

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
