using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FundsCollectionType>))]
public sealed record FundsCollectionType : StringEnum<FundsCollectionType>
{
    private FundsCollectionType(string value) : base(value)
    {
    }

    public static readonly FundsCollectionType UnscheduledRepayment = new("UnscheduledRepayment");

    public static readonly FundsCollectionType Revocation = new("Revocation");

    public static FundsCollectionType FromValue(string value) => FromValueCore(value);
}
