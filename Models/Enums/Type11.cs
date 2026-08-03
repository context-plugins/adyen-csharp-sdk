using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of payment instrument.
/// <para>
/// Possible values: <b>card</b>, <b>bankAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type11>))]
public sealed record Type11 : StringEnum<Type11>
{
    private Type11(string value) : base(value)
    {
    }

    public static readonly Type11 BankAccount = new("bankAccount");

    public static readonly Type11 Card = new("card");

    public static Type11 FromValue(string value) => FromValueCore(value);
}
