using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Reserve</b>
/// * <b>Activate</b>
/// * <b>Load</b>
/// * <b>Unload</b>
/// * <b>Reverse</b>
/// * <b>Duplicate</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueTransactionType>))]
public sealed record StoredValueTransactionType : StringEnum<StoredValueTransactionType>
{
    private StoredValueTransactionType(string value) : base(value)
    {
    }

    public static readonly StoredValueTransactionType Reserve = new("Reserve");

    public static readonly StoredValueTransactionType Activate = new("Activate");

    public static readonly StoredValueTransactionType Load = new("Load");

    public static readonly StoredValueTransactionType Unload = new("Unload");

    public static readonly StoredValueTransactionType Reverse = new("Reverse");

    public static readonly StoredValueTransactionType Duplicate = new("Duplicate");

    public static StoredValueTransactionType FromValue(string value) => FromValueCore(value);
}
