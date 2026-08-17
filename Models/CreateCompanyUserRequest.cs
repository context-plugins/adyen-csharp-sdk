using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateCompanyUserRequest
{
    /// <summary>
    /// The list of <see href="https://docs.adyen.com/account/account-structure#account-groups">account groups</see> associated with this user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountGroups")]
    public IReadOnlyList<string>? AccountGroups { get; init; }

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
    /// The requested login method for the user. To use SSO, you must already have SSO configured with Adyen before creating the user.
    /// <para>
    /// Possible values: <b>Email</b> or <b>SSO</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loginMethod")]
    public string? LoginMethod { get; init; }

    /// <summary>
    /// The user's full name.
    /// <para>
    /// Allowed length: 1—80 characters.
    /// </para>
    /// </summary>
    [JsonPropertyName("name")]
    public required Name Name { get; init; }

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

    /// <summary>
    /// The user's email address that will be their username. Must be the same as the one in the <c>email</c> field.
    /// </summary>
    [JsonPropertyName("username")]
    [StringLength(255, MinimumLength = 1)]
    public required string Username { get; init; }
}
