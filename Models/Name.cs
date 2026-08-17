using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Name of the person., The shopper's full name., the name of the person, The name of the shopper., The shopper's full name., The shopper's name.
/// <para>
/// When the <c>entityType</c> is <c>Company</c>, the <c>shopperName.lastName</c> must contain the company name., The shopper's name.
/// </para>
/// <para>
/// In case the <c>entityType</c> is <c>Company</c>, the <c>shopperName.lastName</c> must contain the company name.
/// </para>
/// <para>
/// &gt; This field is required to update the existing <c>shopperName</c> associated with a recurring contract., Name of the person., The user's full name.
/// </para>
/// <para>
/// Allowed length: 1—80 characters., The user's full name., The name of the contact.
/// </para>
/// </summary>
public record Name
{
    /// <summary>
    /// The first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    [MaxLength(80)]
    public required string FirstName { get; init; }

    /// <summary>
    /// The last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    [MaxLength(80)]
    public required string LastName { get; init; }
}
