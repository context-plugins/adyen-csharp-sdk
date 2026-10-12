namespace Adyen.Requests.GrantsApi;

/// <summary>
/// The inputs of the GetGrantsGrantIdDisbursementsDisbursementId operation.
/// </summary>
public sealed record GetGrantsGrantIdDisbursementsDisbursementIdRequest
{
    /// <summary>
    /// The unique identifier of the grant reference.
    /// </summary>
    public required string GrantId { get; init; }

    /// <summary>
    /// The unique identifier of the disbursement.
    /// </summary>
    public required string DisbursementId { get; init; }
}
