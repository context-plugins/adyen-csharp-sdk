using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>zip</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type58>))]
public sealed record Type58 : OpenStringEnum<Type58>
{
    private Type58(string value) : base(value)
    {
    }

    public static readonly Type58 Zip = new("zip");

    public static readonly Type58 ZipPos = new("zip_pos");

    public TResult Match<TResult>(Func<TResult> onZip, Func<TResult> onZipPos, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Zip => onZip(),
            _ when this == ZipPos => onZipPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onZip, Action onZipPos, Action<string> otherwise)
    {
        if (this == Zip) onZip();
        else if (this == ZipPos) onZipPos();
        else otherwise(Value);
    }
}
