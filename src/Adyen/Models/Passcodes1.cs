using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for <see href="https://docs.adyen.com/point-of-sale/managing-terminals/menu-access?tab=manage_passcodes_with_an_api_call_2#manage-passcodes">passcodes</see> features.
/// </summary>
public record Passcodes1
{
    /// <summary>
    /// The passcode for the Admin menu and the Settings menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adminMenuPin")]
    [MaxLength(6)]
    public string? AdminMenuPin { get; init; }

    /// <summary>
    /// The passcode for referenced and unreferenced refunds on standalone terminals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refundPin")]
    [MaxLength(6)]
    public string? RefundPin { get; init; }

    /// <summary>
    /// The passcode to unlock the terminal screen after a timeout.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("screenLockPin")]
    [StringLength(6, MinimumLength = 4)]
    public string? ScreenLockPin { get; init; }

    /// <summary>
    /// The passcode for the Transactions menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("txMenuPin")]
    [MaxLength(6)]
    public string? TxMenuPin { get; init; }
}
