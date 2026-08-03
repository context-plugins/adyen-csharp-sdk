using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>GetAnyKey</b>
/// * <b>GetConfirmation</b>
/// * <b>SiteManager</b>
/// * <b>TextString</b>
/// * <b>DigitString</b>
/// * <b>DecimalString</b>
/// * <b>GetFunctionKey</b>
/// * <b>GetMenuEntry</b>
/// * <b>Password</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InputCommand>))]
public sealed record InputCommand : StringEnum<InputCommand>
{
    private InputCommand(string value) : base(value)
    {
    }

    public static readonly InputCommand GetAnyKey = new("GetAnyKey");

    public static readonly InputCommand GetConfirmation = new("GetConfirmation");

    public static readonly InputCommand SiteManager = new("SiteManager");

    public static readonly InputCommand TextString = new("TextString");

    public static readonly InputCommand DigitString = new("DigitString");

    public static readonly InputCommand DecimalString = new("DecimalString");

    public static readonly InputCommand GetFunctionKey = new("GetFunctionKey");

    public static readonly InputCommand GetMenuEntry = new("GetMenuEntry");

    public static readonly InputCommand Password = new("Password");

    public static InputCommand FromValue(string value) => FromValueCore(value);
}
