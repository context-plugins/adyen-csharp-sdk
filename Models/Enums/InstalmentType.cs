using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of instalment transaction. For requesting an instalment payment transaction.
/// Possible values:
/// * <b>DeferredInstalments</b>
/// * <b>EqualInstalments</b>
/// * <b>InequalInstalments</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InstalmentType>))]
public sealed record InstalmentType : StringEnum<InstalmentType>
{
    private InstalmentType(string value) : base(value)
    {
    }

    public static readonly InstalmentType DeferredInstalments = new("DeferredInstalments");

    public static readonly InstalmentType EqualInstalments = new("EqualInstalments");

    public static readonly InstalmentType InequalInstalments = new("InequalInstalments");

    public static InstalmentType FromValue(string value) => FromValueCore(value);
}
