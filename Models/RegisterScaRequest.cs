using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RegisterScaRequest
{
    /// <summary>
    /// The name of the SCA device that you are registering. You can use it to help your users identify the device.
    /// <para>
    /// If you do not specify a <c>name</c>, Adyen automatically generates one.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument for which you are registering the SCA device.
    /// </summary>
    [JsonPropertyName("paymentInstrumentId")]
    public required string PaymentInstrumentId { get; init; }

    /// <summary>
    /// Contains information required to register the SCA device.
    /// </summary>
    [JsonPropertyName("strongCustomerAuthentication")]
    public required DelegatedAuthenticationData1 StrongCustomerAuthentication { get; init; }
}
