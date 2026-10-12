using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to <b>push</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>push</b>: _push out funds_ to a destination balance account or transfer instrument.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>pull</b>: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type72>))]
public sealed record Type72 : OpenStringEnum<Type72>
{
    private Type72(string value) : base(value)
    {
    }

    public static readonly Type72 Pull = new("pull");

    public static readonly Type72 Push = new("push");

    public TResult Match<TResult>(Func<TResult> onPull, Func<TResult> onPush, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pull => onPull(),
            _ when this == Push => onPush(),
            _ => otherwise(Value)
        };

    public void Match(Action onPull, Action onPush, Action<string> otherwise)
    {
        if (this == Pull) onPull();
        else if (this == Push) onPush();
        else otherwise(Value);
    }
}
