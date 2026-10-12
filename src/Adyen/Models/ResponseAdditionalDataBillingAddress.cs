using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataBillingAddress
{
    /// <summary>
    /// The billing address city passed in the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress.city")]
    public string? BillingAddressCity { get; init; }

    /// <summary>
    /// The billing address country passed in the payment request.
    /// <para>
    /// Example: NL
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress.country")]
    public string? BillingAddressCountry { get; init; }

    /// <summary>
    /// The billing address house number or name passed in the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress.houseNumberOrName")]
    public string? BillingAddressHouseNumberOrName { get; init; }

    /// <summary>
    /// The billing address postal code passed in the payment request.
    /// <para>
    /// Example: 1011 DJ
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress.postalCode")]
    public string? BillingAddressPostalCode { get; init; }

    /// <summary>
    /// The billing address state or province passed in the payment request.
    /// <para>
    /// Example: NH
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress.stateOrProvince")]
    public string? BillingAddressStateOrProvince { get; init; }

    /// <summary>
    /// The billing address street passed in the payment request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billingAddress.street")]
    public string? BillingAddressStreet { get; init; }
}
