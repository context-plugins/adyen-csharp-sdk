using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BusinessLineInfoUpdate
{
    /// <summary>
    /// A code that represents the industry of your legal entity. For example, <b>4431A</b> for computer software stores.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryCode")]
    public string? IndustryCode { get; init; }

    /// <summary>
    /// The description of the industry code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryCodeDescription")]
    public string? IndustryCodeDescription { get; init; }

    /// <summary>
    /// A list of channels where goods or services are sold.
    /// <para>
    /// Possible values: <b>pos</b>, <b>posMoto</b>, <b>eCommerce</b>, <b>ecomMoto</b>, <b>payByLink</b>.
    /// </para>
    /// <para>
    /// Required only in combination with the <c>service</c> <b>paymentProcessing</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesChannels")]
    public IReadOnlyList<string>? SalesChannels { get; init; }

    /// <summary>
    /// Contains information about the source of your user's funds. Required only if the <c>service</c> is <b>banking</b> or <b>issuing</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceOfFunds")]
    public SourceOfFunds11? SourceOfFunds { get; init; }

    /// <summary>
    /// List of website URLs where your user's goods or services are sold. When this is required for a service but your user does not have an online presence, provide the reason in the <c>webDataExemption</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webData")]
    public IReadOnlyList<WebData>? WebData { get; init; }

    /// <summary>
    /// The reason why the web data is not provided.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webDataExemption")]
    public WebDataExemption1? WebDataExemption { get; init; }
}
