using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AssociationFinaliseRequest
{
    /// <summary>
    /// The list of unique identifiers of the resources that you are associating with the SCA device.
    /// <para>
    /// Maximum: 5 strings.
    /// </para>
    /// </summary>
    [JsonPropertyName("ids")]
    public required IReadOnlyList<string> Ids { get; init; }

    /// <summary>
    /// Contains authentication information required to associate the resource with the SCA device.
    /// </summary>
    [JsonPropertyName("strongCustomerAuthentication")]
    public required AssociationDelegatedAuthenticationData1 StrongCustomerAuthentication { get; init; }

    /// <summary>
    /// The type of resource that you are associating with the SCA device.
    /// <para>
    /// Possible value: <b>PaymentInstrument</b>
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "PaymentInstrument";
}
