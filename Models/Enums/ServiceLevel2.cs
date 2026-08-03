using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the service level (settlement type) of this payment method. Required for merchants operating in Japan.
/// Possible values:
/// * <b>noContract</b>: Adyen holds the contract with JCB for merchants operating in Japan or American Express for merchants operating in Canada, Australia and New Zealand.
/// * <b>gatewayContract</b>: JCB or American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
/// * <b>paymentDesignatorContract</b>: Available only for merchants operating in Canada, Australia and New Zealand. Adyen receives the settlement, and handles disputes and payouts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceLevel2>))]
public sealed record ServiceLevel2 : StringEnum<ServiceLevel2>
{
    private ServiceLevel2(string value) : base(value)
    {
    }

    public static readonly ServiceLevel2 NoContract = new("noContract");

    public static readonly ServiceLevel2 GatewayContract = new("gatewayContract");

    public static readonly ServiceLevel2 PaymentDesignatorContract = new("paymentDesignatorContract");

    public static ServiceLevel2 FromValue(string value) => FromValueCore(value);
}
