using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details of the account holder migrated to the balance platform.
/// </summary>
public record MigrationData2
{
    /// <summary>
    /// The unique identifier of the account holder in the balance platform.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderId")]
    public string? AccountHolderId { get; init; }

    /// <summary>
    /// The unique identifier of the balance platfrom to which the account holder was migrated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balancePlatform")]
    public string? BalancePlatform { get; init; }

    /// <summary>
    /// Set to <b>true</b> if the account holder has been migrated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migrated")]
    public bool? Migrated { get; init; }

    /// <summary>
    /// Contains the mapping of virtual account codes (classic integration) to the balance account codes (balance platform) associated with the migrated account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migratedAccounts")]
    public IReadOnlyList<MigratedAccounts>? MigratedAccounts { get; init; }

    /// <summary>
    /// Contains the mapping of shareholders associated with the migrated legal entities.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migratedShareholders")]
    public IReadOnlyList<MigratedShareholders>? MigratedShareholders { get; init; }

    /// <summary>
    /// Contains the mapping of business lines and stores associated with the migrated account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migratedStores")]
    public IReadOnlyList<MigratedStores>? MigratedStores { get; init; }

    /// <summary>
    /// The date when account holder was migrated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("migrationDate")]
    public DateTimeOffset? MigrationDate { get; init; }
}
