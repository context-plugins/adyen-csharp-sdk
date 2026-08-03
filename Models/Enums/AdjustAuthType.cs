using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of adjustment. Possible values:
/// <list type="bullet">
///   <item><description><b>cardholderInitiatedTransaction</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>merchantInitiatedTransaction</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AdjustAuthType>))]
public sealed record AdjustAuthType : StringEnum<AdjustAuthType>
{
    private AdjustAuthType(string value) : base(value)
    {
    }

    public static readonly AdjustAuthType CardholderInitiatedTransaction = new("cardholderInitiatedTransaction");

    public static readonly AdjustAuthType MerchantInitiatedTransaction = new("merchantInitiatedTransaction");

    public static AdjustAuthType FromValue(string value) => FromValueCore(value);
}
