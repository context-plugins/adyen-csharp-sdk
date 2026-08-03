using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>payu_IN_upi</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type77>))]
public sealed record Type77 : StringEnum<Type77>
{
    private Type77(string value) : base(value)
    {
    }

    public static readonly Type77 PayuInUpi = new("payu_IN_upi");

    public static Type77 FromValue(string value) => FromValueCore(value);
}
