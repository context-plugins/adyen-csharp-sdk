using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>GiftCard</b>
/// * <b>PhoneCard</b>
/// * <b>Other</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueAccountType>))]
public sealed record StoredValueAccountType : StringEnum<StoredValueAccountType>
{
    private StoredValueAccountType(string value) : base(value)
    {
    }

    public static readonly StoredValueAccountType GiftCard = new("GiftCard");

    public static readonly StoredValueAccountType PhoneCard = new("PhoneCard");

    public static readonly StoredValueAccountType Other = new("Other");

    public static StoredValueAccountType FromValue(string value) => FromValueCore(value);
}
