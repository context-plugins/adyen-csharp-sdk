using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer instrument.
/// <para>
/// Possible value: <b>bankAccount</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type221>))]
public sealed record Type221 : StringEnum<Type221>
{
    private Type221(string value) : base(value)
    {
    }

    public static readonly Type221 BankAccount = new("bankAccount");

    public static readonly Type221 RecurringDetail = new("recurringDetail");

    public static Type221 FromValue(string value) => FromValueCore(value);
}
