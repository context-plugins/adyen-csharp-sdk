using System.ComponentModel.DataAnnotations;
using Adyen.Models.Enums;

namespace Adyen.Requests.DynamicOffers;

/// <summary>
/// The inputs of the GetDynamicOffers operation.
/// </summary>
public sealed record GetDynamicOffersRequest
{
    /// <summary>
    /// The unique identifier of the account holder that the dynamic offer is for.
    /// </summary>
    [MinLength(1)]
    public required string AccountHolderId { get; init; }

    /// <summary>
    /// The type of financing that the offer is for. If the value is not specified, returns all available types.
    /// <para>
    /// Possible values: <b>businessFinancing</b>
    /// </para>
    /// </summary>
    public FinancingType? FinancingType { get; init; }
}
