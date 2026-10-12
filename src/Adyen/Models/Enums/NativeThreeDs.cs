using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2">native 3D Secure authentication</see> should be triggered when available. Adyen can still select to fallback to the redirect flow to optimize authorization rates and improve the shopper's experience.
/// <para>
/// Possible values:
/// * <b>preferred</b>: Use native 3D Secure authentication when available.
/// * <b>disabled</b>: Use the redirect 3D Secure authentication flow.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NativeThreeDs>))]
public sealed record NativeThreeDs : OpenStringEnum<NativeThreeDs>
{
    private NativeThreeDs(string value) : base(value)
    {
    }

    public static readonly NativeThreeDs Preferred = new("preferred");

    public static readonly NativeThreeDs Disabled = new("disabled");

    public TResult Match<TResult>(Func<TResult> onPreferred,
        Func<TResult> onDisabled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Preferred => onPreferred(),
            _ when this == Disabled => onDisabled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPreferred, Action onDisabled, Action<string> otherwise)
    {
        if (this == Preferred) onPreferred();
        else if (this == Disabled) onDisabled();
        else otherwise(Value);
    }
}
