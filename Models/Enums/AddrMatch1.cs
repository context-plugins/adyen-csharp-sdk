using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether the cardholder shipping Address and cardholder billing address are the same. Allowed values:
/// * <b>Y</b> — Shipping Address matches Billing Address.
/// * <b>N</b> — Shipping Address does not match Billing Address.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AddrMatch1>))]
public sealed record AddrMatch1 : StringEnum<AddrMatch1>
{
    private AddrMatch1(string value) : base(value)
    {
    }

    public static readonly AddrMatch1 Y = new("Y");

    public static readonly AddrMatch1 N = new("N");

    public static AddrMatch1 FromValue(string value) => FromValueCore(value);
}
