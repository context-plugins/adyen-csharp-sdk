using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Expiry month for the test card range.
/// <para>
/// Allowed values:
/// * JANUARY
/// * FEBRUARY
/// * MARCH
/// * APRIL
/// * MAY
/// * JUNE
/// * JULY
/// * AUGUST
/// * SEPTEMBER
/// * OCTOBER
/// * NOVEMBER
/// * DECEMBER
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExpiryMonth>))]
public sealed record ExpiryMonth : StringEnum<ExpiryMonth>
{
    private ExpiryMonth(string value) : base(value)
    {
    }

    public static readonly ExpiryMonth April = new("APRIL");

    public static readonly ExpiryMonth August = new("AUGUST");

    public static readonly ExpiryMonth December = new("DECEMBER");

    public static readonly ExpiryMonth February = new("FEBRUARY");

    public static readonly ExpiryMonth January = new("JANUARY");

    public static readonly ExpiryMonth July = new("JULY");

    public static readonly ExpiryMonth June = new("JUNE");

    public static readonly ExpiryMonth March = new("MARCH");

    public static readonly ExpiryMonth May = new("MAY");

    public static readonly ExpiryMonth November = new("NOVEMBER");

    public static readonly ExpiryMonth October = new("OCTOBER");

    public static readonly ExpiryMonth September = new("SEPTEMBER");

    public static ExpiryMonth FromValue(string value) => FromValueCore(value);
}
