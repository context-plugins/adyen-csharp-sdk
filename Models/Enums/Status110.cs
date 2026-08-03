using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>credited</b>: the funds are credited to your user's transfer instrument or bank account.- <b>accepted</b>: the request is accepted by the integration.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status110>))]
public sealed record Status110 : StringEnum<Status110>
{
    private Status110(string value) : base(value)
    {
    }

    public static readonly Status110 Credited = new("credited");

    public static readonly Status110 Accepted = new("accepted");

    public static Status110 FromValue(string value) => FromValueCore(value);
}
