using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for the amount update. Possible values:
/// * <b>delayedCharge</b>
/// * <b>noShow</b>
/// * <b>installment</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IndustryUsage1>))]
public sealed record IndustryUsage1 : StringEnum<IndustryUsage1>
{
    private IndustryUsage1(string value) : base(value)
    {
    }

    public static readonly IndustryUsage1 DelayedCharge = new("delayedCharge");

    public static readonly IndustryUsage1 Installment = new("installment");

    public static readonly IndustryUsage1 NoShow = new("noShow");

    public static IndustryUsage1 FromValue(string value) => FromValueCore(value);
}
