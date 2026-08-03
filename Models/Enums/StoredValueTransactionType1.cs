using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Identification of operation to proceed on the stored value account or the stored value card.
/// Possible values:
/// * <b>Activate</b>
/// * <b>Duplicate</b>
/// * <b>Load</b>
/// * <b>Reserve</b>
/// * <b>Reverse</b>
/// * <b>Unload</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoredValueTransactionType1>))]
public sealed record StoredValueTransactionType1 : StringEnum<StoredValueTransactionType1>
{
    private StoredValueTransactionType1(string value) : base(value)
    {
    }

    public static readonly StoredValueTransactionType1 Reserve = new("Reserve");

    public static readonly StoredValueTransactionType1 Activate = new("Activate");

    public static readonly StoredValueTransactionType1 Load = new("Load");

    public static readonly StoredValueTransactionType1 Unload = new("Unload");

    public static readonly StoredValueTransactionType1 Reverse = new("Reverse");

    public static readonly StoredValueTransactionType1 Duplicate = new("Duplicate");

    public static StoredValueTransactionType1 FromValue(string value) => FromValueCore(value);
}
