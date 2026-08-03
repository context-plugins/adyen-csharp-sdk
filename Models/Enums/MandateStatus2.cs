using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the mandate.
/// <para>
/// Possible values: <b>pending</b>, <b>approved</b>, <b>cancelled</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MandateStatus2>))]
public sealed record MandateStatus2 : StringEnum<MandateStatus2>
{
    private MandateStatus2(string value) : base(value)
    {
    }

    public static readonly MandateStatus2 Pending = new("pending");

    public static readonly MandateStatus2 Approved = new("approved");

    public static readonly MandateStatus2 Cancelled = new("cancelled");

    public static MandateStatus2 FromValue(string value) => FromValueCore(value);
}
