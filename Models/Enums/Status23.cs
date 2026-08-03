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
[JsonConverter(typeof(StringEnumConverter<Status23>))]
public sealed record Status23 : StringEnum<Status23>
{
    private Status23(string value) : base(value)
    {
    }

    public static readonly Status23 Authorised = new("authorised");

    public static readonly Status23 Received = new("received");

    public static readonly Status23 Refused = new("refused");

    public static Status23 FromValue(string value) => FromValueCore(value);
}
