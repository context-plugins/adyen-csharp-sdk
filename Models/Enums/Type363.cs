using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paymentInstrumentRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type363>))]
public sealed record Type363 : StringEnum<Type363>
{
    private Type363(string value) : base(value)
    {
    }

    public static readonly Type363 PaymentInstrumentRequirement = new("paymentInstrumentRequirement");

    public static Type363 FromValue(string value) => FromValueCore(value);
}
