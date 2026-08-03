using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>econtextvoucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type29>))]
public sealed record Type29 : StringEnum<Type29>
{
    private Type29(string value) : base(value)
    {
    }

    public static readonly Type29 EcontextSevenEleven = new("econtext_seven_eleven");

    public static readonly Type29 EcontextOnline = new("econtext_online");

    public static readonly Type29 Econtext = new("econtext");

    public static readonly Type29 EcontextStores = new("econtext_stores");

    public static readonly Type29 EcontextAtm = new("econtext_atm");

    public static Type29 FromValue(string value) => FromValueCore(value);
}
