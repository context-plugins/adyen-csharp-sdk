namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the PostCompaniesCompanyIdTerminalOrdersOrderIdCancel operation.
/// </summary>
public sealed record PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }
}
