using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// In 3D Secure 2, this is the <c>transStatus</c> from the challenge result. If the transaction was frictionless, omit this parameter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AuthenticationResponse>))]
public sealed record AuthenticationResponse : OpenStringEnum<AuthenticationResponse>
{
    private AuthenticationResponse(string value) : base(value)
    {
    }

    public static readonly AuthenticationResponse Y = new("Y");

    public static readonly AuthenticationResponse N = new("N");

    public static readonly AuthenticationResponse U = new("U");

    public static readonly AuthenticationResponse A = new("A");

    public TResult Match<TResult>(Func<TResult> onY,
        Func<TResult> onN,
        Func<TResult> onU,
        Func<TResult> onA,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Y => onY(),
            _ when this == N => onN(),
            _ when this == U => onU(),
            _ when this == A => onA(),
            _ => otherwise(Value)
        };

    public void Match(Action onY, Action onN, Action onU, Action onA, Action<string> otherwise)
    {
        if (this == Y) onY();
        else if (this == N) onN();
        else if (this == U) onU();
        else if (this == A) onA();
        else otherwise(Value);
    }
}
