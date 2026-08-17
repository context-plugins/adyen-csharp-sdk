using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of error.
/// <para>
/// Possible values:
/// *  <b>invalidInput</b>
/// *  <b>dataMissing</b>
/// *  <b>pendingStatus</b>
/// *  <b>rejected</b>
/// *  <b>dataReview</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type512>))]
public sealed record Type512 : StringEnum<Type512>
{
    private Type512(string value) : base(value)
    {
    }

    public static readonly Type512 DataMissing = new("dataMissing");

    public static readonly Type512 DataReview = new("dataReview");

    public static readonly Type512 InvalidInput = new("invalidInput");

    public static readonly Type512 PendingStatus = new("pendingStatus");

    public static readonly Type512 Rejected = new("rejected");

    public static Type512 FromValue(string value) => FromValueCore(value);
}
