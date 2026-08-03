using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the payment instrument. If a status is not specified when creating a payment instrument, it is set to <b>active</b> by default. However, there can be exceptions for cards based on the <c>card.formFactor</c> and the <c>issuingCountryCode</c>. For example, when issuing physical cards in the US, the default status is <b>inactive</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>active</b>:  The payment instrument is active and can be used to make payments.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>inactive</b>: The payment instrument is inactive and cannot be used to make payments.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>suspended</b>: The payment instrument is suspended, either because it was stolen or lost.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>closed</b>: The payment instrument is permanently closed. This action cannot be undone.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status10>))]
public sealed record Status10 : StringEnum<Status10>
{
    private Status10(string value) : base(value)
    {
    }

    public static readonly Status10 Active = new("active");

    public static readonly Status10 Closed = new("closed");

    public static readonly Status10 Inactive = new("inactive");

    public static readonly Status10 Suspended = new("suspended");

    public static Status10 FromValue(string value) => FromValueCore(value);
}
