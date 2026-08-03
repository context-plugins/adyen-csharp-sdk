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
[JsonConverter(typeof(StringEnumConverter<Type21>))]
public sealed record Type21 : StringEnum<Type21>
{
    private Type21(string value) : base(value)
    {
    }

    public static readonly Type21 DataMissing = new("dataMissing");

    public static readonly Type21 DataReview = new("dataReview");

    public static readonly Type21 InvalidInput = new("invalidInput");

    public static readonly Type21 PendingStatus = new("pendingStatus");

    public static Type21 FromValue(string value) => FromValueCore(value);
}
