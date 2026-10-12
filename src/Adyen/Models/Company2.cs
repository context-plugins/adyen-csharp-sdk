using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Company2
{
    /// <summary>
    /// References to resources connected with this company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public CompanyLinks2? Links { get; init; }

    /// <summary>
    /// List of available data centers.
    /// <para>
    /// Adyen has several data centers around the world.In the URL that you use for making API requests, we recommend you use the live URL prefix from the data center closest to your shoppers.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataCenters")]
    public IReadOnlyList<DataCenter>? DataCenters { get; init; }

    /// <summary>
    /// Your description for the company account, maximum 300 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The legal or trading name of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Your reference to the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The status of the company account.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Active</b>: Users can log in. Processing and payout capabilities depend on the status of the merchant account.</description></item>
    ///   <item><description><b>Inactive</b>: Users can log in. Payment processing and payouts are disabled.</description></item>
    ///   <item><description><b>Closed</b>: The company account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
