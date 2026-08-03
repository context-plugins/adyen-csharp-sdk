using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DisputeStatus>))]
public sealed record DisputeStatus : StringEnum<DisputeStatus>
{
    private DisputeStatus(string value) : base(value)
    {
    }

    public static readonly DisputeStatus Draft = new("draft");

    public static readonly DisputeStatus Submitted = new("submitted");

    public static readonly DisputeStatus Chargeback = new("chargeback");

    public static readonly DisputeStatus SecondPresentment = new("secondPresentment");

    public static readonly DisputeStatus Won = new("won");

    public static readonly DisputeStatus Closed = new("closed");

    public static DisputeStatus FromValue(string value) => FromValueCore(value);
}
