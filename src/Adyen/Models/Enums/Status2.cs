using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of your request.
/// <para>
/// If you included <c>adjustAuthorisationData</c> in your request, possible values are the following:
/// </para>
/// <list type="bullet">
///   <item><description><b>authorised</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>refused</b></description></item>
/// </list>
/// <para>
/// Otherwise, the value is <b>received</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : OpenStringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Authorised = new("authorised");

    public static readonly Status2 Received = new("received");

    public static readonly Status2 Refused = new("refused");

    public TResult Match<TResult>(Func<TResult> onAuthorised,
        Func<TResult> onReceived,
        Func<TResult> onRefused,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Authorised => onAuthorised(),
            _ when this == Received => onReceived(),
            _ when this == Refused => onRefused(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuthorised, Action onReceived, Action onRefused, Action<string> otherwise)
    {
        if (this == Authorised) onAuthorised();
        else if (this == Received) onReceived();
        else if (this == Refused) onRefused();
        else otherwise(Value);
    }
}
