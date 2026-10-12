using Adyen.Models;

namespace Adyen.Requests.TransactionRules;

/// <summary>
/// The inputs of the PatchTransactionRulesTransactionRuleId operation.
/// </summary>
public sealed record PatchTransactionRulesTransactionRuleIdRequest
{
    /// <summary>
    /// The unique identifier of the transaction rule.
    /// </summary>
    public required string TransactionRuleId { get; init; }

    public TransactionRuleInfo? Body { get; init; }
}
