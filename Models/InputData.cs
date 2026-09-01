using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InputData
{
    /// <summary>
    /// Logical device located on a Sale Terminal or a POI Terminal, regarding the class of information to output (display, print or store), or input (keyboard) for the Cashier or the Customer.
    /// Possible values:
    /// * <b>CashierDisplay</b>
    /// * <b>CashierInput</b>
    /// * <b>CustomerDisplay</b>
    /// * <b>CustomerInput</b>
    /// </summary>
    [JsonPropertyName("Device")]
    public required Device2 Device { get; init; }

    /// <summary>
    /// Qualification of the information to send to an output logical device, to display or print to the Cashier or the Customer.
    /// Possible values:
    /// * <b>CustomerAssistance</b>
    /// * <b>Display</b>
    /// * <b>Document</b>
    /// * <b>Error</b>
    /// * <b>Input</b>
    /// * <b>POIReplication</b>
    /// * <b>Receipt</b>
    /// * <b>Sound</b>
    /// * <b>Status</b>
    /// * <b>Voucher</b>
    /// </summary>
    [JsonPropertyName("InfoQualify")]
    public required InfoQualify2 InfoQualify { get; init; }

    /// <summary>
    /// Type of requested input. Can be: <b>GetConfirmation</b>, <b>TextString</b>, <b>DigitString</b>, <b>DecimalString</b> or <b>GetMenuEntry</b>.
    /// Possible values:
    /// * <b>DecimalString</b>
    /// * <b>DigitString</b>
    /// * <b>GetAnyKey</b>
    /// * <b>GetConfirmation</b>
    /// * <b>GetFunctionKey</b>
    /// * <b>GetMenuEntry</b>
    /// * <b>Password</b>
    /// * <b>SiteManager</b>
    /// * <b>TextString</b>
    /// </summary>
    [JsonPropertyName("InputCommand")]
    public required InputCommand1 InputCommand { get; init; }

    /// <summary>
    /// Request Notification of the card entered in the POI card reader.
    /// </summary>
    [JsonPropertyName("NotifyCardInputFlag")]
    public bool? NotifyCardInputFlag { get; init; } = false;

    /// <summary>
    /// Maximum input time in seconds. Limits the time to answer to an Input request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxInputTime")]
    public int? MaxInputTime { get; init; }

    /// <summary>
    /// Indicates whether to request an Immediate response to the message without waiting for the completion of the command.
    /// </summary>
    [JsonPropertyName("ImmediateResponseFlag")]
    public bool? ImmediateResponseFlag { get; init; } = false;

    /// <summary>
    /// Minimum length of an entered string, or minimum number of entries that can be selected in a menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MinLength")]
    public int? MinLength { get; init; }

    /// <summary>
    /// Maximum length of an entered string, or maximum number of entries that can be selected in a menu.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxLength")]
    public int? MaxLength { get; init; }

    /// <summary>
    /// Maximum input length of the decimal part (without decimal point).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxDecimalLength")]
    public int? MaxDecimalLength { get; init; }

    /// <summary>
    /// Indicates that the user must confirm the entered characters, when the maximum allowed length is reached. During the processing of an Input command <c>TextString</c>, <c>DigitString</c> or <c>DecimalString</c> with <c>MaxLength</c> or <c>MaxDecimalLength</c> present in the request.
    /// </summary>
    [JsonPropertyName("WaitUserValidationFlag")]
    public bool? WaitUserValidationFlag { get; init; } = true;

    /// <summary>
    /// Default string value for an input command. On the <c>TextString</c>, <c>DigitString</c> and <c>DecimalString</c> input commands: default string displayed on the input field before entering the string. In <c>GetConfirmation</c> input command: <b>Y</b> for yes, <b>N</b> for no.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DefaultInputString")]
    [RegularExpression("^.+$")]
    public string? DefaultInputString { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DefaultLayoutString")]
    [RegularExpression("^.+$")]
    public string? DefaultLayoutString { get; init; }

    /// <summary>
    /// String mask to get information requiring a specific format. For the processing of an Input command <c>TextString</c>, <c>DigitString</c> or <c>DecimalString</c>. Some information as date or plate number required to be entered with a certain format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StringMask")]
    [RegularExpression("^.+$")]
    public string? StringMask { get; init; }

    /// <summary>
    /// Indicates if the entered character has to be displayed from the right to the left of the display field.
    /// </summary>
    [JsonPropertyName("FromRightToLeftFlag")]
    public bool? FromRightToLeftFlag { get; init; } = false;

    /// <summary>
    /// Indicates to mask the characters entered by the user (i.e. replacing in the display of the input, the entered character by a standard character as *).
    /// </summary>
    [JsonPropertyName("MaskCharactersFlag")]
    public bool? MaskCharactersFlag { get; init; } = false;

    /// <summary>
    /// Indicates, when the user press a key, if a beep has to be generated (value True).
    /// </summary>
    [JsonPropertyName("BeepKeyFlag")]
    public bool? BeepKeyFlag { get; init; } = false;

    /// <summary>
    /// Indicates, when the user presses the Correct function key in an input entry, if all the entered characters are removed (value True) or only the last entered character if any (value False).
    /// </summary>
    [JsonPropertyName("GlobalCorrectionFlag")]
    public bool? GlobalCorrectionFlag { get; init; } = false;

    /// <summary>
    /// Indicates if the Cancel function key has to be deactivated (value True).
    /// </summary>
    [JsonPropertyName("DisableCancelFlag")]
    public bool? DisableCancelFlag { get; init; } = false;

    /// <summary>
    /// Indicates if the Correct function key has to be deactivated (value True). During the processing of an Input command <c>GetConfirmation</c>, <c>SiteManager</c>, or <c>GetMenuEntry</c>.
    /// </summary>
    [JsonPropertyName("DisableCorrectFlag")]
    public bool? DisableCorrectFlag { get; init; } = false;

    /// <summary>
    /// Indicates if the Valid function key has to be deactivated (value True). During the processing of an Input command <c>GetConfirmation</c>, <c>SiteManager</c>, or <c>GetMenuEntry</c>.
    /// </summary>
    [JsonPropertyName("DisableValidFlag")]
    public bool? DisableValidFlag { get; init; } = false;

    /// <summary>
    /// If it has the value True, it indicates that the Back function key (respectively Home function key) may be used to go back to the immediate upper level of the menu. If it has the value False, it indicates that the current menu level has no parent menu.
    /// </summary>
    [JsonPropertyName("MenuBackFlag")]
    public bool? MenuBackFlag { get; init; } = false;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
