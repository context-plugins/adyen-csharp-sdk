using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FinancingType>))]
public sealed record FinancingType : StringEnum<FinancingType>
{
    private FinancingType(string value) : base(value)
    {
    }

    public static readonly FinancingType HardwareFinancing = new("hardwareFinancing");

    public static readonly FinancingType BusinessFinancing = new("businessFinancing");

    public static FinancingType FromValue(string value) => FromValueCore(value);
}
