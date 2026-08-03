using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MandateStatus>))]
public sealed record MandateStatus : StringEnum<MandateStatus>
{
    private MandateStatus(string value) : base(value)
    {
    }

    public static readonly MandateStatus Pending = new("pending");

    public static readonly MandateStatus Approved = new("approved");

    public static readonly MandateStatus Cancelled = new("cancelled");

    public static MandateStatus FromValue(string value) => FromValueCore(value);
}
