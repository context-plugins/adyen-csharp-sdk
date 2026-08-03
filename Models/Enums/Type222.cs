using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer instrument.
/// <para>
/// Possible value: <b>bankAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type222>))]
public sealed record Type222 : StringEnum<Type222>
{
    private Type222(string value) : base(value)
    {
    }

    public static readonly Type222 BankAccount = new("bankAccount");

    public static readonly Type222 RecurringDetail = new("recurringDetail");

    public static Type222 FromValue(string value) => FromValueCore(value);
}
