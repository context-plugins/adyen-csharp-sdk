using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of resource that you are associating with the SCA device.
/// <para>
/// Possible value: <b>PaymentInstrument</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type103>))]
public sealed record Type103 : StringEnum<Type103>
{
    private Type103(string value) : base(value)
    {
    }

    public static readonly Type103 PaymentInstrument = new("PaymentInstrument");

    public static Type103 FromValue(string value) => FromValueCore(value);
}
