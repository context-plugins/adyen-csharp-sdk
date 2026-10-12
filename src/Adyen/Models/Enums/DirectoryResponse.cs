using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// In 3D Secure 2, this is the <c>transStatus</c> from the <c>ARes</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DirectoryResponse>))]
public sealed record DirectoryResponse : OpenStringEnum<DirectoryResponse>
{
    private DirectoryResponse(string value) : base(value)
    {
    }

    public static readonly DirectoryResponse A = new("A");

    public static readonly DirectoryResponse C = new("C");

    public static readonly DirectoryResponse D = new("D");

    public static readonly DirectoryResponse I = new("I");

    public static readonly DirectoryResponse N = new("N");

    public static readonly DirectoryResponse R = new("R");

    public static readonly DirectoryResponse U = new("U");

    public static readonly DirectoryResponse Y = new("Y");

    public TResult Match<TResult>(Func<TResult> onA,
        Func<TResult> onC,
        Func<TResult> onD,
        Func<TResult> onI,
        Func<TResult> onN,
        Func<TResult> onR,
        Func<TResult> onU,
        Func<TResult> onY,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == A => onA(),
            _ when this == C => onC(),
            _ when this == D => onD(),
            _ when this == I => onI(),
            _ when this == N => onN(),
            _ when this == R => onR(),
            _ when this == U => onU(),
            _ when this == Y => onY(),
            _ => otherwise(Value)
        };

    public void Match(Action onA,
        Action onC,
        Action onD,
        Action onI,
        Action onN,
        Action onR,
        Action onU,
        Action onY,
        Action<string> otherwise)
    {
        if (this == A) onA();
        else if (this == C) onC();
        else if (this == D) onD();
        else if (this == I) onI();
        else if (this == N) onN();
        else if (this == R) onR();
        else if (this == U) onU();
        else if (this == Y) onY();
        else otherwise(Value);
    }
}
