using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UsLocalAccountIdentification1Properties
{
    /// <summary>
    /// The bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(18, MinimumLength = 2)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The bank account type.
    /// <para>
    /// Possible values: <b>checking</b> or <b>savings</b>. Defaults to <b>checking</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public AccountType2? AccountType { get; init; }

    /// <summary>
    /// The 9-digit <see href="https://en.wikipedia.org/wiki/ABA_routing_transit_number">routing number</see>, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("routingNumber")]
    [StringLength(9, MinimumLength = 9)]
    public required string RoutingNumber { get; init; }

    /// <summary>
    /// <b>usLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "usLocal";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
