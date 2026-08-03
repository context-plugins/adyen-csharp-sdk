using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The service for which you are creating the business line.
/// <para>
///
/// </para>
/// <para>
/// Possible values:
/// *  <b>paymentProcessing</b>
/// *  <b>issuing</b>
/// *  <b>banking</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Service>))]
public sealed record Service : StringEnum<Service>
{
    private Service(string value) : base(value)
    {
    }

    public static readonly Service PaymentProcessing = new("paymentProcessing");

    public static readonly Service Issuing = new("issuing");

    public static readonly Service Banking = new("banking");

    public static Service FromValue(string value) => FromValueCore(value);
}
