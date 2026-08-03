using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Wallet Provider Device Type and the operation.
/// <para>
/// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
/// </para>
/// <para>
/// Supported value inputs:
/// - <b>MOBILE_PHONE</b>
/// - <b>TABLET_OR_EREADER</b>
/// - <b>WATCH_OR_WRISTBAND</b>
/// - <b>WEARABLE</b>
/// </para>
/// <list type="bullet">
///   <item><description><b>CARD</b></description></item>
///   <item><description><b>PC</b></description></item>
///   <item><description><b>OTHER</b></description></item>
///   <item><description><b>UNKNOWN</b></description></item>
/// </list>
/// </summary>
public record WalletProviderDeviceType2
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<Value6>? Value { get; init; }
}
