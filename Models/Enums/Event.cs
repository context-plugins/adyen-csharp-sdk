using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The event.
/// &gt;Permitted values: <c>InactivateAccount</c>, <c>RefundNotPaidOutTransfers</c>.
/// For more information, refer to <see href="https://docs.adyen.com/classic-platforms/verification-process">Verification checks</see>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Event>))]
public sealed record Event : StringEnum<Event>
{
    private Event(string value) : base(value)
    {
    }

    public static readonly Event InactivateAccount = new("InactivateAccount");

    public static readonly Event RefundNotPaidOutTransfers = new("RefundNotPaidOutTransfers");

    public static Event FromValue(string value) => FromValueCore(value);
}
