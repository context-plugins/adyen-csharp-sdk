using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the Cardholder Name on the account is identical to the shipping Name used for this transaction.
/// Allowed values:
/// * <b>01</b> — Account Name identical to shipping Name
/// * <b>02</b> — Account Name different to shipping Name
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShipNameIndicator>))]
public sealed record ShipNameIndicator : StringEnum<ShipNameIndicator>
{
    private ShipNameIndicator(string value) : base(value)
    {
    }

    public static readonly ShipNameIndicator _01 = new("01");

    public static readonly ShipNameIndicator _02 = new("02");

    public static ShipNameIndicator FromValue(string value) => FromValueCore(value);
}
