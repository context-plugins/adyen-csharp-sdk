using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BalanceAccountUpdateRequest
{
    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/accountHolders#responses-200-id">account holder</see> associated with the balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderId")]
    public string? AccountHolderId { get; init; }

    /// <summary>
    /// A human-readable description of the balance account. You can use this parameter to distinguish between multiple balance accounts under an account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public string? Description { get; init; }

    /// <summary>
    /// A set of key and value pairs for general use.
    /// The keys do not have specific names and may be used for storing miscellaneous data as desired.
    /// &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformPaymentConfiguration")]
    public PlatformPaymentConfiguration? PlatformPaymentConfiguration { get; init; }

    /// <summary>
    /// Your reference to the balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status41? Status { get; init; }

    /// <summary>
    /// The time zone of the balance account. For example, <b>Europe/Amsterdam</b>.
    /// Defaults to the time zone of the account holder if no time zone is set. For possible values, see the <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">list of time zone codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; init; }
}
