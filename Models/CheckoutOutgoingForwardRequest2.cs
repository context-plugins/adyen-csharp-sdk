using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The <see href="https://docs.adyen.com/online-payments/tokenization/forward-payment-details#request-to-adyen-card">details of the request</see> that you want to forward to the third-party.
/// </summary>
public record CheckoutOutgoingForwardRequest2
{
    /// <summary>
    /// The request body that you want Adyen to forward to the third party on your behalf, in string format.
    /// <para>
    /// Include key value pairs to specify the payment details, and use <see href="https://docs.adyen.com/online-payments/tokenization/forward-payment-details#placeholders">placeholders</see> for the values. Adyen replaces the placeholders with the payment details when making the request to the third party.
    /// </para>
    /// <para>
    /// When forwarding a network token, include a <see href="https://docs.adyen.com/online-payments/tokenization/forward-payment-details#conditional-placeholders">condition</see> that checks if the network token exists, and informs Adyen of which fields to send depending on the outcome.
    /// </para>
    /// </summary>
    [JsonPropertyName("body")]
    [MaxLength(20000)]
    public required string Body { get; init; }

    /// <summary>
    /// Your credentials that are needed to authenticate with the third party.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("credentials")]
    public string? Credentials { get; init; }

    /// <summary>
    /// The request headers that will be included in the request Adyen makes to the third party on your behalf. Supports the <c>{{credentials}}</c> <see href="https://docs.adyen.com/online-payments/tokenization/forward-payment-details#placeholders">placeholder</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headers")]
    public IReadOnlyDictionary<string, string>? Headers { get; init; }

    [JsonPropertyName("httpMethod")]
    public required HttpMethodEnum HttpMethod { get; init; }

    /// <summary>
    /// The suffix that Adyen needs to append to the <c>baseUrl</c> to construct the destination URL that belongs to the third party. This is usually the endpoint name for the request, for example, <b>/payments</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("urlSuffix")]
    public string? UrlSuffix { get; init; }
}
