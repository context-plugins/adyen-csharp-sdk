using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the service level (settlement type) of this payment method. Required for merchants operating in Japan. Possible values:
///  * <b>noContract</b>: Adyen holds the contract with JCB.
///  * <b>gatewayContract</b>: JCB receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceLevel1>))]
public sealed record ServiceLevel1 : StringEnum<ServiceLevel1>
{
    private ServiceLevel1(string value) : base(value)
    {
    }

    public static readonly ServiceLevel1 NoContract = new("noContract");

    public static readonly ServiceLevel1 GatewayContract = new("gatewayContract");

    public static ServiceLevel1 FromValue(string value) => FromValueCore(value);
}
