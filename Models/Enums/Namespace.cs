using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The namespace that corresponds to the reason code.
/// <para>
/// Possible values:
/// *  <b>ukFpsRejectionCode</b>
/// *  <b>ukFpsReturnReasonCode</b>
/// *  <b>usAchReturnReasonCode</b>
/// *  <b>iso8583ResponseCode</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Namespace>))]
public sealed record Namespace : StringEnum<Namespace>
{
    private Namespace(string value) : base(value)
    {
    }

    public static readonly Namespace Iso8583ResponseCode = new("iso8583ResponseCode");

    public static readonly Namespace UkFpsRejectionCode = new("ukFpsRejectionCode");

    public static readonly Namespace UkFpsReturnReasonCode = new("ukFpsReturnReasonCode");

    public static readonly Namespace UsAchReturnReasonCode = new("usAchReturnReasonCode");

    public static Namespace FromValue(string value) => FromValueCore(value);
}
