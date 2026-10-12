using Adyen.Models;

namespace Adyen.Requests.TransactionRules;

/// <summary>
/// The inputs of the PostTransactionRules operation.
/// </summary>
public sealed record PostTransactionRulesRequest
{
    public TransactionRuleInfo? Body { get; init; }
}
