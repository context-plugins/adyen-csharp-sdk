using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data entered by the user, related to the input command.
/// </summary>
public record Input2
{
    [JsonPropertyName("InputCommand")]
    public required InputCommand1 InputCommand { get; init; }

    /// <summary>
    /// Indicates te response of the user from the <c>GetConfirmation</c> input command.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ConfirmedFlag")]
    public bool? ConfirmedFlag { get; init; }

    /// <summary>
    /// The number of the function key which is typed by the Customer on the POI or the Cashier on the Sale Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("FunctionKey")]
    public int? FunctionKey { get; init; }

    /// <summary>
    /// The text typed by the Customer on the POI or by the Cashier on the Sale Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TextInput")]
    public string? TextInput { get; init; }

    /// <summary>
    /// The digits typed by the Customer on the POI or by the Cashier on the Sale Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DigitInput")]
    public int? DigitInput { get; init; }

    /// <summary>
    /// The text password typed by the Customer on the POI or by the Cashier on the Sale Terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Password")]
    public string? Password { get; init; }

    /// <summary>
    /// The index of the menu item (from 1 to n) which is selected by the Cashier on the Sale Terminal. The value -1 indicates that the immediate upper level of the menu is requested. The value 0 indicates that the root of the menu is requested.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MenuEntryNumber")]
    public IReadOnlyList<int>? MenuEntryNumber { get; init; }
}
