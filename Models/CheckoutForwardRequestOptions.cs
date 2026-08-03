using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutForwardRequestOptions
{
    /// <summary>
    /// Whether to check for a card account update (true) or not (false)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountUpdate")]
    public bool? AccountUpdate { get; init; }

    /// <summary>
    /// Set to <b>true</b> to receive a copy of the request Adyen is making to the third party in the response. Any sensitive information will be masked in the response you receive. This functionality is only available in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkToken")]
    public CheckoutNetworkTokenOption? NetworkToken { get; init; }

    /// <summary>
    /// Set in tokenize:true case when forwarding PAN. Addresses to the possible location(s) of networkTxReference in the incoming 3rd party response
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkTxReferencePaths")]
    public IReadOnlyList<string>? NetworkTxReferencePaths { get; init; }

    /// <summary>
    /// Set to <b>true</b>, the payment details are <see href="https://docs.adyen.com/online-payments/tokenization">tokenized</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenize")]
    public bool? Tokenize { get; init; }

    /// <summary>
    /// Set in tokenize:true case when forwarding PAN. Addresses to the possible location(s) of transactionLinkId in the incoming 3rd party response
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLinkIdPaths")]
    public IReadOnlyList<string>? TransactionLinkIdPaths { get; init; }
}
