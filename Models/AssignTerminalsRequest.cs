using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AssignTerminalsRequest
{
    /// <summary>
    /// Your company account. To return terminals to the company inventory, specify only this parameter and the <c>terminals</c>.
    /// </summary>
    [JsonPropertyName("companyAccount")]
    public required string CompanyAccount { get; init; }

    /// <summary>
    /// Name of the merchant account. Specify this parameter to assign terminals to this merchant account or to a store under this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// Boolean that indicates if you are assigning the terminals to the merchant inventory. Do not use when assigning terminals to a store. Required when assigning the terminal to a merchant account.
    /// <list type="bullet">
    ///   <item><description>Set this to <b>true</b> to assign the terminals to the merchant inventory. This also means that the terminals cannot be boarded.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Set this to <b>false</b> to assign the terminals to the merchant account as in-store terminals. This makes the terminals ready to be boarded and to process payments through the specified merchant account.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantInventory")]
    public bool? MerchantInventory { get; init; }

    /// <summary>
    /// The store code of the store that you want to assign the terminals to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("store")]
    public string? Store { get; init; }

    /// <summary>
    /// Array containing a list of terminal IDs that you want to assign or reassign to the merchant account or store, or that you want to return to the company inventory.
    /// <para>
    /// For example, <c>["V400m-324689776","P400Plus-329127412"]</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("terminals")]
    public required IReadOnlyList<string> Terminals { get; init; }
}
