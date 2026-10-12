using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of load you are trying to do, when absent we default to 'load'
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoadType>))]
public sealed record LoadType : OpenStringEnum<LoadType>
{
    private LoadType(string value) : base(value)
    {
    }

    public static readonly LoadType MerchandiseReturn = new("merchandiseReturn");

    public static readonly LoadType Load = new("load");

    public TResult Match<TResult>(Func<TResult> onMerchandiseReturn,
        Func<TResult> onLoad,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MerchandiseReturn => onMerchandiseReturn(),
            _ when this == Load => onLoad(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchandiseReturn, Action onLoad, Action<string> otherwise)
    {
        if (this == MerchandiseReturn) onMerchandiseReturn();
        else if (this == Load) onLoad();
        else otherwise(Value);
    }
}
