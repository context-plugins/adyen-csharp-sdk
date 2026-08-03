using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paybybank_pix</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type45>))]
public sealed record Type45 : StringEnum<Type45>
{
    private Type45(string value) : base(value)
    {
    }

    public static readonly Type45 PaybybankPix = new("paybybank_pix");

    public static Type45 FromValue(string value) => FromValueCore(value);
}
