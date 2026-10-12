using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
/// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
/// <para>
/// This field has the following possible values:
/// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
/// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
/// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
/// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal., Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
/// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
/// </para>
/// <para>
/// This field has the following possible values:
/// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
/// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the card holder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
/// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
/// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal., Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
/// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
/// </para>
/// <para>
/// This field has the following possible values:
/// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorisation rates, we recommend sending the card security code (CSC) along with the request.
/// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorisation (one-click payment).
/// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
/// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShopperInteraction>))]
public sealed record ShopperInteraction : OpenStringEnum<ShopperInteraction>
{
    private ShopperInteraction(string value) : base(value)
    {
    }

    public static readonly ShopperInteraction Ecommerce = new("Ecommerce");

    public static readonly ShopperInteraction ContAuth = new("ContAuth");

    public static readonly ShopperInteraction Moto = new("Moto");

    public static readonly ShopperInteraction Pos = new("POS");

    public TResult Match<TResult>(Func<TResult> onEcommerce,
        Func<TResult> onContAuth,
        Func<TResult> onMoto,
        Func<TResult> onPos,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ecommerce => onEcommerce(),
            _ when this == ContAuth => onContAuth(),
            _ when this == Moto => onMoto(),
            _ when this == Pos => onPos(),
            _ => otherwise(Value)
        };

    public void Match(Action onEcommerce, Action onContAuth, Action onMoto, Action onPos, Action<string> otherwise)
    {
        if (this == Ecommerce) onEcommerce();
        else if (this == ContAuth) onContAuth();
        else if (this == Moto) onMoto();
        else if (this == Pos) onPos();
        else otherwise(Value);
    }
}
