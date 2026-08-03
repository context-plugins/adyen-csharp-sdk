using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of load you are trying to do, when absent we default to 'load'
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LoadType>))]
public sealed record LoadType : StringEnum<LoadType>
{
    private LoadType(string value) : base(value)
    {
    }

    public static readonly LoadType MerchandiseReturn = new("merchandiseReturn");

    public static readonly LoadType Load = new("load");

    public static LoadType FromValue(string value) => FromValueCore(value);
}
