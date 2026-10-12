using System;
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
public sealed record InputCommand1 : OpenStringEnum<InputCommand1>
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

    public TResult Match<TResult>(Func<TResult> onGetAnyKey,
        Func<TResult> onGetConfirmation,
        Func<TResult> onSiteManager,
        Func<TResult> onTextString,
        Func<TResult> onDigitString,
        Func<TResult> onDecimalString,
        Func<TResult> onGetFunctionKey,
        Func<TResult> onGetMenuEntry,
        Func<TResult> onPassword,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GetAnyKey => onGetAnyKey(),
            _ when this == GetConfirmation => onGetConfirmation(),
            _ when this == SiteManager => onSiteManager(),
            _ when this == TextString => onTextString(),
            _ when this == DigitString => onDigitString(),
            _ when this == DecimalString => onDecimalString(),
            _ when this == GetFunctionKey => onGetFunctionKey(),
            _ when this == GetMenuEntry => onGetMenuEntry(),
            _ when this == Password => onPassword(),
            _ => otherwise(Value)
        };

    public void Match(Action onGetAnyKey,
        Action onGetConfirmation,
        Action onSiteManager,
        Action onTextString,
        Action onDigitString,
        Action onDecimalString,
        Action onGetFunctionKey,
        Action onGetMenuEntry,
        Action onPassword,
        Action<string> otherwise)
    {
        if (this == GetAnyKey) onGetAnyKey();
        else if (this == GetConfirmation) onGetConfirmation();
        else if (this == SiteManager) onSiteManager();
        else if (this == TextString) onTextString();
        else if (this == DigitString) onDigitString();
        else if (this == DecimalString) onDecimalString();
        else if (this == GetFunctionKey) onGetFunctionKey();
        else if (this == GetMenuEntry) onGetMenuEntry();
        else if (this == Password) onPassword();
        else otherwise(Value);
    }
}
