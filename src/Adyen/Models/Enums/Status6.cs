using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status you want to change to, The status of the sweep. If not provided, by default, this is set to <b>active</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>:  the sweep is enabled and funds will be pulled in or pushed out based on the defined configuration.</description></item>
/// </list>
/// <para>
///  * <b>inactive</b>: the sweep is disabled and cannot be triggered., The status of the transaction rule. If you provide a <c>startDate</c> in the request, the rule is automatically created
/// with an <b>active</b> status.
/// </para>
/// <para>
/// Possible values: <b>active</b>, <b>inactive</b>., The status of the webhook setting. Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>: You receive a balance webhook if any of the conditions in this setting are met.</description></item>
///   <item><description><b>inactive</b>: You do not receive a balance webhook even if the conditions in this settings are met., The status of the recurring top-up. If not provided, by default, this is set to <b>active</b>.</description></item>
/// </list>
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>:  the top up is enabled and funds will be pulled in.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>inactive</b>: the top up is disabled and cannot be triggered.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status6>))]
public sealed record Status6 : OpenStringEnum<Status6>
{
    private Status6(string value) : base(value)
    {
    }

    public static readonly Status6 Active = new("active");

    public static readonly Status6 Inactive = new("inactive");

    public TResult Match<TResult>(Func<TResult> onActive, Func<TResult> onInactive, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onInactive, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else otherwise(Value);
    }
}
