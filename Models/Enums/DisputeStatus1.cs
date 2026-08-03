using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The current status of the dispute.
/// <para>
/// When you create a dispute, you can only set the <c>status</c> to <b>draft</b>. When you update a dispute, you can set the <c>status</c> to <b>submitted</b> or <b>closed</b>.
/// </para>
/// <para>
/// Possible values: <b>draft</b>, <b>submitted</b>, <b>closed</b>, <b>won</b>, <b>chargeback</b>, <b>secondPresentment</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisputeStatus1>))]
public sealed record DisputeStatus1 : StringEnum<DisputeStatus1>
{
    private DisputeStatus1(string value) : base(value)
    {
    }

    public static readonly DisputeStatus1 Draft = new("draft");

    public static readonly DisputeStatus1 Submitted = new("submitted");

    public static readonly DisputeStatus1 Chargeback = new("chargeback");

    public static readonly DisputeStatus1 SecondPresentment = new("secondPresentment");

    public static readonly DisputeStatus1 Won = new("won");

    public static readonly DisputeStatus1 Closed = new("closed");

    public static DisputeStatus1 FromValue(string value) => FromValueCore(value);
}
