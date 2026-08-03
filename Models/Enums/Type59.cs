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
[JsonConverter(typeof(StringEnumConverter<Type59>))]
public sealed record Type59 : StringEnum<Type59>
{
    private Type59(string value) : base(value)
    {
    }

    public static readonly Type59 DataMissing = new("dataMissing");

    public static readonly Type59 DataReview = new("dataReview");

    public static readonly Type59 InvalidInput = new("invalidInput");

    public static readonly Type59 PendingStatus = new("pendingStatus");

    public static readonly Type59 Rejected = new("rejected");

    public static Type59 FromValue(string value) => FromValueCore(value);
}
