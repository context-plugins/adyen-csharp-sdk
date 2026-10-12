using System.ComponentModel.DataAnnotations;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Requests.ScaAssociationManagement;

/// <summary>
/// The inputs of the GetScaAssociations operation.
/// </summary>
public sealed record GetScaAssociationsRequest
{
    /// <summary>
    /// The type of entity you want to retrieve a list of associations for.
    /// <para>
    /// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
    /// </para>
    /// </summary>
    public required ScaEntityType EntityType { get; init; }

    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    [StringLength(100, MinimumLength = 1)]
    public required string EntityId { get; init; }

    /// <summary>
    /// The number of items to have on a page.
    /// <para>
    /// Default: <b>5</b>.
    /// </para>
    /// </summary>
    [Minimum(1)]
    [Maximum(10)]
    public required int PageSize { get; init; }

    /// <summary>
    /// The index of the page to retrieve. The index of the first page is <b>0</b> (zero).
    /// <para>
    /// Default:  <b>0</b>.
    /// </para>
    /// </summary>
    public required int PageNumber { get; init; }
}
