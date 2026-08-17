using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>PAN</b>
/// * <b>ISOTrack2</b>
/// * <b>BarCode</b>
/// * <b>AccountNumber</b>
/// * <b>PhoneNumber</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationType1>))]
public sealed record IdentificationType1 : StringEnum<IdentificationType1>
{
    private IdentificationType1(string value) : base(value)
    {
    }

    public static readonly IdentificationType1 Pan = new("PAN");

    public static readonly IdentificationType1 IsoTrack2 = new("ISOTrack2");

    public static readonly IdentificationType1 BarCode = new("BarCode");

    public static readonly IdentificationType1 AccountNumber = new("AccountNumber");

    public static readonly IdentificationType1 PhoneNumber = new("PhoneNumber");

    public static IdentificationType1 FromValue(string value) => FromValueCore(value);
}
