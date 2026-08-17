using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies the sales channel, through which the shopper gives their card details, and whether the shopper is a returning customer.
/// For the web service API, Adyen assumes Ecommerce shopper interaction by default.
/// <para>
/// This field has the following possible values:
/// * <c>Ecommerce</c> - Online transactions where the cardholder is present (online). For better authorization rates, we recommend sending the card security code (CSC) along with the request.
/// * <c>ContAuth</c> - Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer). If the shopper is present (online), you can supply also the CSC to improve authorization (one-click payment).
/// * <c>Moto</c> - Mail-order and telephone-order transactions where the shopper is in contact with the merchant via email or telephone.
/// * <c>POS</c> - Point-of-sale transactions where the shopper is physically present to make a payment using a secure payment terminal.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShopperInteraction3>))]
public sealed record ShopperInteraction3 : StringEnum<ShopperInteraction3>
{
    private ShopperInteraction3(string value) : base(value)
    {
    }

    public static readonly ShopperInteraction3 Ecommerce = new("Ecommerce");

    public static readonly ShopperInteraction3 ContAuth = new("ContAuth");

    public static readonly ShopperInteraction3 Moto = new("Moto");

    public static readonly ShopperInteraction3 Pos = new("POS");

    public static ShopperInteraction3 FromValue(string value) => FromValueCore(value);
}
