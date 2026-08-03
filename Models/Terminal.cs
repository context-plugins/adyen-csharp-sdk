using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Terminal
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assignment")]
    public TerminalAssignment? Assignment { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/terminal-api/1/overview#endpoints-for-cloud-communications">regional base URL</see> to use for sending Terminal API requests when using cloud communications.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cloudDeviceApiEndpoint")]
    public string? CloudDeviceApiEndpoint { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connectivity")]
    public TerminalConnectivity? Connectivity { get; init; }

    /// <summary>
    /// The country code of the country where the terminal is located.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; init; }

    /// <summary>
    /// The software release currently in use on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("firmwareVersion")]
    public string? FirmwareVersion { get; init; }

    /// <summary>
    /// The unique identifier of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A list of Android apps installed on the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installedAPKs")]
    public IReadOnlyList<InstalledApks>? InstalledApks { get; init; }

    /// <summary>
    /// Date and time of the last activity on the terminal. Not included when the last activity was more than 14 days ago.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastActivityAt")]
    public DateTimeOffset? LastActivityAt { get; init; }

    /// <summary>
    /// Date and time of the last transaction on the terminal. Not included when the last transaction was more than 14 days ago.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastTransactionAt")]
    public DateTimeOffset? LastTransactionAt { get; init; }

    /// <summary>
    /// The model name of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("model")]
    public string? Model { get; init; }

    /// <summary>
    /// The exact time of the terminal reboot, in the timezone of the terminal in <b>HH:mm</b> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restartLocalTime")]
    public string? RestartLocalTime { get; init; }

    /// <summary>
    /// The serial number of the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; init; }
}
