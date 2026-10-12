using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the service level (settlement type) of this payment method. Possible values:
/// * <b>noContract</b>: Adyen holds the contract with American Express.
/// * <b>gatewayContract</b>: American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
/// * <b>paymentDesignatorContract</b>: Adyen receives the settlement, and handles disputes and payouts.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceLevel>))]
public sealed record ServiceLevel : OpenStringEnum<ServiceLevel>
{
    private ServiceLevel(string value) : base(value)
    {
    }

    public static readonly ServiceLevel NoContract = new("noContract");

    public static readonly ServiceLevel GatewayContract = new("gatewayContract");

    public static readonly ServiceLevel PaymentDesignatorContract = new("paymentDesignatorContract");

    public TResult Match<TResult>(Func<TResult> onNoContract,
        Func<TResult> onGatewayContract,
        Func<TResult> onPaymentDesignatorContract,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoContract => onNoContract(),
            _ when this == GatewayContract => onGatewayContract(),
            _ when this == PaymentDesignatorContract => onPaymentDesignatorContract(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoContract,
        Action onGatewayContract,
        Action onPaymentDesignatorContract,
        Action<string> otherwise)
    {
        if (this == NoContract) onNoContract();
        else if (this == GatewayContract) onGatewayContract();
        else if (this == PaymentDesignatorContract) onPaymentDesignatorContract();
        else otherwise(Value);
    }
}
