using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of financing that the offer is for. If the value is not specified, returns all available types.
/// <para>
/// Possible values: <b>businessFinancing</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FinancingType1>))]
public sealed record FinancingType1 : StringEnum<FinancingType1>
{
    private FinancingType1(string value) : base(value)
    {
    }

    public static readonly FinancingType1 HardwareFinancing = new("hardwareFinancing");

    public static readonly FinancingType1 BusinessFinancing = new("businessFinancing");

    public static FinancingType1 FromValue(string value) => FromValueCore(value);
}
