using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of account identification. In a request message, it informs the POI System the type of the account or card identification, when provided by the Sale Terminal. (e.g. because the card information is a barcode read by the Cashier on a scanner device). In a response message, it informs the Sale System the type of the account or card identification.
/// Possible values:
/// * <b>AccountNumber</b>
/// * <b>BarCode</b>
/// * <b>ISOTrack2</b>
/// * <b>PAN</b>
/// * <b>PhoneNumber</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationType11>))]
public sealed record IdentificationType11 : StringEnum<IdentificationType11>
{
    private IdentificationType11(string value) : base(value)
    {
    }

    public static readonly IdentificationType11 Pan = new("PAN");

    public static readonly IdentificationType11 IsoTrack2 = new("ISOTrack2");

    public static readonly IdentificationType11 BarCode = new("BarCode");

    public static readonly IdentificationType11 AccountNumber = new("AccountNumber");

    public static readonly IdentificationType11 PhoneNumber = new("PhoneNumber");

    public static IdentificationType11 FromValue(string value) => FromValueCore(value);
}
