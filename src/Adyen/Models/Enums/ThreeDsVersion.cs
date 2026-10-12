using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The version of 3D Secure to use.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>2.1.0</b></description></item>
///   <item><description><b>2.2.0</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsVersion>))]
public sealed record ThreeDsVersion : OpenStringEnum<ThreeDsVersion>
{
    private ThreeDsVersion(string value) : base(value)
    {
    }

    public static readonly ThreeDsVersion _210 = new("2.1.0");

    public static readonly ThreeDsVersion _220 = new("2.2.0");

    public TResult Match<TResult>(Func<TResult> on_210, Func<TResult> on_220, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _210 => on_210(),
            _ when this == _220 => on_220(),
            _ => otherwise(Value)
        };

    public void Match(Action on_210, Action on_220, Action<string> otherwise)
    {
        if (this == _210) on_210();
        else if (this == _220) on_220();
        else otherwise(Value);
    }
}
