using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<InputCommand1>))]
public sealed record InputCommand1 : StringEnum<InputCommand1>
{
    private InputCommand1(string value) : base(value)
    {
    }

    public static readonly InputCommand1 GetAnyKey = new("GetAnyKey");

    public static readonly InputCommand1 GetConfirmation = new("GetConfirmation");

    public static readonly InputCommand1 SiteManager = new("SiteManager");

    public static readonly InputCommand1 TextString = new("TextString");

    public static readonly InputCommand1 DigitString = new("DigitString");

    public static readonly InputCommand1 DecimalString = new("DecimalString");

    public static readonly InputCommand1 GetFunctionKey = new("GetFunctionKey");

    public static readonly InputCommand1 GetMenuEntry = new("GetMenuEntry");

    public static readonly InputCommand1 Password = new("Password");

    public static InputCommand1 FromValue(string value) => FromValueCore(value);
}
