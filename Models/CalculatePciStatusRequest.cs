using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CalculatePciStatusRequest
{
    /// <summary>
    /// An array of additional sales channels to generate PCI questionnaires. Include the relevant sales channels if you need your user to sign PCI questionnaires. Not required if you <see href="https://docs.adyen.com/platforms">create stores</see> and <see href="https://docs.adyen.com/adyen-for-platforms-model">add payment methods</see> before you generate the questionnaires.
    /// <para>
    /// Possible values:
    /// *  <b>eCommerce</b>
    /// *  <b>pos</b>
    /// *  <b>ecomMoto</b>
    /// *  <b>posMoto</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalSalesChannels")]
    public IReadOnlyList<AdditionalSalesChannel>? AdditionalSalesChannels { get; init; }
}
