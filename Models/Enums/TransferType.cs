using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer to which the limit applies. Possible values:
/// * <b>instant</b>: the limit applies to transfers with an <b>instant</b> priority.
/// * <b>all</b>: the limit applies to all transfers, regardless of priority.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferType>))]
public sealed record TransferType : StringEnum<TransferType>
{
    private TransferType(string value) : base(value)
    {
    }

    public static readonly TransferType Instant = new("instant");

    public static readonly TransferType All = new("all");

    public static TransferType FromValue(string value) => FromValueCore(value);
}
