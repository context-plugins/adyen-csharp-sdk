using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of stored value account. Allows the distinction of the stored value instrument to access the stored value account.
/// Possible values:
/// * <b>GiftCard</b>
/// * <b>Other</b>
/// * <b>PhoneCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueAccountType1>))]
public sealed record StoredValueAccountType1 : StringEnum<StoredValueAccountType1>
{
    private StoredValueAccountType1(string value) : base(value)
    {
    }

    public static readonly StoredValueAccountType1 GiftCard = new("GiftCard");

    public static readonly StoredValueAccountType1 PhoneCard = new("PhoneCard");

    public static readonly StoredValueAccountType1 Other = new("Other");

    public static StoredValueAccountType1 FromValue(string value) => FromValueCore(value);
}
