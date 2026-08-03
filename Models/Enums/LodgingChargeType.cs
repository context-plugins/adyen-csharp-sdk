using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The category of lodging charges for the payment.
/// * <b>additionalData key:</b> <c>lodging.specialProgramCode</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LodgingChargeType>))]
public sealed record LodgingChargeType : StringEnum<LodgingChargeType>
{
    private LodgingChargeType(string value) : base(value)
    {
    }

    public static readonly LodgingChargeType AdvanceDeposit = new("advanceDeposit");

    public static readonly LodgingChargeType NoShow = new("noShow");

    public static readonly LodgingChargeType Stay = new("stay");

    public static LodgingChargeType FromValue(string value) => FromValueCore(value);
}
