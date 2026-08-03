using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Status of the payment link. Possible values:
/// * <b>expired</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status28>))]
public sealed record Status28 : StringEnum<Status28>
{
    private Status28(string value) : base(value)
    {
    }

    public static readonly Status28 Expired = new("expired");

    public static Status28 FromValue(string value) => FromValueCore(value);
}
