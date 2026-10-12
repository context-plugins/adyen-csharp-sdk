namespace Adyen.Requests.TransactionRules;

/// <summary>
/// The inputs of the DeleteTransactionRulesTransactionRuleId operation.
/// </summary>
public sealed record DeleteTransactionRulesTransactionRuleIdRequest
{
    /// <summary>
    /// The unique identifier of the transaction rule.
    /// </summary>
    public required string TransactionRuleId { get; init; }
}
