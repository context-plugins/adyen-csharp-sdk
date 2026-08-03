using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AccountHolderInfo
{
    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id">balance platform</see> to which the account holder belongs. Required in the request if your API credentials can be used for multiple balance platforms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balancePlatform")]
    public string? BalancePlatform { get; init; }

    /// <summary>
    /// Contains key-value pairs that specify the actions that an account holder can do in your platform. The key is a capability required for your integration. For example, <b>issueCard</b> for Issuing. The value is an object containing the settings for the capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyDictionary<string, AccountHolderCapability>? Capabilities { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contactDetails")]
    public ContactDetails? ContactDetails { get; init; }

    /// <summary>
    /// Your description for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id">legal entity</see> associated with the account holder. Adyen performs a verification process against the legal entity of the account holder.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    public required string LegalEntityId { get; init; }

    /// <summary>
    /// A set of key and value pairs for general use.
    /// The keys do not have specific names and may be used for storing miscellaneous data as desired.
    /// &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// The unique identifier of the migrated account holder in the classic integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migratedAccountHolderCode")]
    public string? MigratedAccountHolderCode { get; init; }

    /// <summary>
    /// Your reference for the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(150)]
    public string? Reference { get; init; }

    /// <summary>
    /// The time zone of the account holder. For example, <b>Europe/Amsterdam</b>.
    /// Defaults to the time zone of the balance platform if no time zone is set. For possible values, see the <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">list of time zone codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; init; }
}
