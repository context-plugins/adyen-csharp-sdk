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
public sealed record Status2 : StringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Authorised = new("authorised");

    public static readonly Status2 Received = new("received");

    public static readonly Status2 Refused = new("refused");

    public static Status2 FromValue(string value) => FromValueCore(value);
}
