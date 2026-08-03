using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The fraud result properties of the payment. Possible values:
/// * AMBER
/// * GREEN
/// * RED
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FraudResultType>))]
public sealed record FraudResultType : StringEnum<FraudResultType>
{
    private FraudResultType(string value) : base(value)
    {
    }

    public static readonly FraudResultType Amber = new("AMBER");

    public static readonly FraudResultType Green = new("GREEN");

    public static readonly FraudResultType Red = new("RED");

    public static FraudResultType FromValue(string value) => FromValueCore(value);
}
