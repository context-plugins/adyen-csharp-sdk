using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// 3D Secure server response. It notifies whether the specified card holder is enrolled in a 3D Secure service. Possible values:
/// <list type="bullet">
///   <item><description>Y (Authentication available)</description></item>
///   <item><description>N (Card holder not enrolled/not participating)</description></item>
///   <item><description>U (Unable to authenticate)</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDDirectoryServerResponse>))]
public sealed record ThreeDDirectoryServerResponse : OpenStringEnum<ThreeDDirectoryServerResponse>
{
    private ThreeDDirectoryServerResponse(string value) : base(value)
    {
    }

    public static readonly ThreeDDirectoryServerResponse N = new("N");

    public static readonly ThreeDDirectoryServerResponse U = new("U");

    public static readonly ThreeDDirectoryServerResponse Y = new("Y");

    public TResult Match<TResult>(Func<TResult> onN,
        Func<TResult> onU,
        Func<TResult> onY,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == N => onN(),
            _ when this == U => onU(),
            _ when this == Y => onY(),
            _ => otherwise(Value)
        };

    public void Match(Action onN, Action onU, Action onY, Action<string> otherwise)
    {
        if (this == N) onN();
        else if (this == U) onU();
        else if (this == Y) onY();
        else otherwise(Value);
    }
}
