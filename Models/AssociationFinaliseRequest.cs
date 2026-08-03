using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

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

    [JsonPropertyName("strongCustomerAuthentication")]
    public required AssociationDelegatedAuthenticationData StrongCustomerAuthentication { get; init; }

    /// <summary>
    /// The type of resource that you are associating with the SCA device.
    /// <para>
    /// Possible value: <b>PaymentInstrument</b>
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type103 Type { get; init; }
}
