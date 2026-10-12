using System;
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
public sealed record InputCommand : OpenStringEnum<InputCommand>
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
