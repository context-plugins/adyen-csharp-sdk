using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FindTerminalResponse
{
    /// <summary>
    /// The company account that the terminal is associated with. If this is the only account level shown in the response, the terminal is assigned to the inventory of the company account.
    /// </summary>
    [JsonPropertyName("companyAccount")]
    public required string CompanyAccount { get; init; }

    /// <summary>
    /// The merchant account that the terminal is associated with. If the response doesn't contain a <c>store</c> the terminal is assigned to this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// Boolean that indicates if the terminal is assigned to the merchant inventory. This is returned when the terminal is assigned to a merchant account.
    /// <list type="bullet">
    ///   <item><description>If <b>true</b>, this indicates that the terminal is in the merchant inventory. This also means that the terminal cannot be boarded.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If <b>false</b>, this indicates that the terminal is assigned to the merchant account as an in-store terminal. This means that the terminal is ready to be boarded, or is already boarded.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantInventory")]
    public bool? MerchantInventory { get; init; }

    /// <summary>
    /// The store code of the store that the terminal is assigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }

    /// <summary>
    /// The unique terminal ID.
    /// </summary>
    [JsonPropertyName("terminal")]
    public required string Terminal { get; init; }
}
