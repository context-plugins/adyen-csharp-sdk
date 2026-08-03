using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdateMerchantUserRequest
{
    /// <summary>
    /// The list of <see href="https://docs.adyen.com/account/account-structure#account-groups">account groups</see> associated with this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroups")]
    public IReadOnlyList<string>? AccountGroups { get; init; }

    /// <summary>
    /// Sets the status of the user to active (<b>true</b>) or inactive (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The email address of the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    /// <summary>
    /// The requested login method for the user. To use SSO, you must already have SSO configured with Adyen before creating the user.
    /// <para>
    /// Possible values: <b>Email</b> or <b>SSO</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loginMethod")]
    public string? LoginMethod { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name22? Name { get; init; }

    /// <summary>
    /// The list of <see href="https://docs.adyen.com/account/user-roles">roles</see> for this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    public IReadOnlyList<string>? Roles { get; init; }

    /// <summary>
    /// The <see href="https://en.wikipedia.org/wiki/List_of_tz_database_time_zones">tz database name</see> of the time zone of the user. For example, <b>Europe/Amsterdam</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeZoneCode")]
    public string? TimeZoneCode { get; init; }
}
