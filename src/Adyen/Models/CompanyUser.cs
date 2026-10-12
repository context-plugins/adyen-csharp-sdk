using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CompanyUser
{
    /// <summary>
    /// References to resources connected with this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public Links1? Links { get; init; }

    /// <summary>
    /// The list of <see href="https://docs.adyen.com/account/account-structure#account-groups">account groups</see> associated with this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroups")]
    public IReadOnlyList<string>? AccountGroups { get; init; }

    /// <summary>
    /// Indicates whether this user is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// Set of apps available to this user
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("apps")]
    public IReadOnlyList<string>? Apps { get; init; }

    /// <summary>
    /// The list of <see href="https://docs.adyen.com/account/account-structure#merchant-accounts">merchant accounts</see> associated with this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("associatedMerchantAccounts")]
    public IReadOnlyList<string>? AssociatedMerchantAccounts { get; init; }

    /// <summary>
    /// The email address of the user.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The user's full name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name? Name { get; init; }

    /// <summary>
    /// The list of <see href="https://docs.adyen.com/account/user-roles">roles</see> for this user.
    /// </summary>
    [JsonPropertyName("roles")]
    public required IReadOnlyList<string> Roles { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">tz database name</see> of the time zone of the user. For example, <b>Europe/Amsterdam</b>.
    /// </summary>
    [JsonPropertyName("timeZoneCode")]
    public required string TimeZoneCode { get; init; }

    /// <summary>
    /// The username for this user.
    /// </summary>
    [JsonPropertyName("username")]
    [StringLength(255, MinimumLength = 1)]
    public required string Username { get; init; }
}
