using System.Text.Json.Serialization;
using Adyen.Models.AnyOf;

namespace Adyen.Models;

/// <summary>
/// Contains information about the transfer related to the transaction.
/// </summary>
public record TransferView2
{
    /// <summary>
    /// The relevant data according to the transfer category.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("categoryData")]
    public CategoryData? CategoryData { get; init; }

    /// <summary>
    /// The ID of the resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/transfers/latest/post/transfers__reqParam_reference"><c>reference</c></see> from the <c>/transfers</c> request. If you haven't provided any, Adyen generates a unique reference.
    /// </summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; init; }
}
