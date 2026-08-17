using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of payment instrument.
/// <para>
/// Possible values: <b>card</b>, <b>bankAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type111>))]
public sealed record Type111 : StringEnum<Type111>
{
    private Type111(string value) : base(value)
    {
    }

    public static readonly Type111 BankAccount = new("bankAccount");

    public static readonly Type111 Card = new("card");

    public static Type111 FromValue(string value) => FromValueCore(value);
}
