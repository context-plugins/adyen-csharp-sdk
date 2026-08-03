using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Identification of operation to proceed on the stored value account or the stored value card.
/// Copy.
/// Possible values:
/// * <b>Activate</b>
/// * <b>Duplicate</b>
/// * <b>Load</b>
/// * <b>Reserve</b>
/// * <b>Reverse</b>
/// * <b>Unload</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueTransactionType2>))]
public sealed record StoredValueTransactionType2 : StringEnum<StoredValueTransactionType2>
{
    private StoredValueTransactionType2(string value) : base(value)
    {
    }

    public static readonly StoredValueTransactionType2 Reserve = new("Reserve");

    public static readonly StoredValueTransactionType2 Activate = new("Activate");

    public static readonly StoredValueTransactionType2 Load = new("Load");

    public static readonly StoredValueTransactionType2 Unload = new("Unload");

    public static readonly StoredValueTransactionType2 Reverse = new("Reverse");

    public static readonly StoredValueTransactionType2 Duplicate = new("Duplicate");

    public static StoredValueTransactionType2 FromValue(string value) => FromValueCore(value);
}
