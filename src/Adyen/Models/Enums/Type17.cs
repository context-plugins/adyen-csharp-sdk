using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>Cellulant</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type17>))]
public sealed record Type17 : OpenStringEnum<Type17>
{
    private Type17(string value) : base(value)
    {
    }

    public static readonly Type17 Cellulant = new("cellulant");

    public TResult Match<TResult>(Func<TResult> onCellulant, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cellulant => onCellulant(),
            _ => otherwise(Value)
        };

    public void Match(Action onCellulant, Action<string> otherwise)
    {
        if (this == Cellulant) onCellulant();
        else otherwise(Value);
    }
}
