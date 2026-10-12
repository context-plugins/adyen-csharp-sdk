namespace Adyen.Requests.TransactionRules;

/// <summary>
/// The inputs of the GetTransactionRulesTransactionRuleId operation.
/// </summary>
public sealed record GetTransactionRulesTransactionRuleIdRequest
{
    /// <summary>
    /// The unique identifier of the transaction rule.
    /// </summary>
    public required string TransactionRuleId { get; init; }
}
