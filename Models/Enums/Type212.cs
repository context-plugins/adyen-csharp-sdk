using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of error.
/// <para>
///
/// </para>
/// <para>
/// Possible values:
/// *  <b>invalidInput</b>
/// *  <b>dataMissing</b>
/// *  <b>pendingStatus</b>
/// *  <b>dataReview</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type212>))]
public sealed record Type212 : StringEnum<Type212>
{
    private Type212(string value) : base(value)
    {
    }

    public static readonly Type212 DataMissing = new("dataMissing");

    public static readonly Type212 DataReview = new("dataReview");

    public static readonly Type212 InvalidInput = new("invalidInput");

    public static readonly Type212 PendingStatus = new("pendingStatus");

    public static Type212 FromValue(string value) => FromValueCore(value);
}
