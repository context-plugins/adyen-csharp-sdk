using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of funds collection.
/// <para>
/// Possible values: <b>UnscheduledRepayment</b>, <b>Revocation</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FundsCollectionType2>))]
public sealed record FundsCollectionType2 : StringEnum<FundsCollectionType2>
{
    private FundsCollectionType2(string value) : base(value)
    {
    }

    public static readonly FundsCollectionType2 UnscheduledRepayment = new("UnscheduledRepayment");

    public static readonly FundsCollectionType2 Revocation = new("Revocation");

    public static FundsCollectionType2 FromValue(string value) => FromValueCore(value);
}
