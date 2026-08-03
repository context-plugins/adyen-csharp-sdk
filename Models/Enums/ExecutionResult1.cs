using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the payout execution.
/// <para>
/// Possible values:
/// - <b>succeeded</b>: The payout was sent successfully.
/// - <b>failed</b>: The payout could not be sent because an error occurred.
/// - <b>skipped</b>: The payout was not triggered as expected.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExecutionResult1>))]
public sealed record ExecutionResult1 : StringEnum<ExecutionResult1>
{
    private ExecutionResult1(string value) : base(value)
    {
    }

    public static readonly ExecutionResult1 Failed = new("failed");

    public static readonly ExecutionResult1 Succeeded = new("succeeded");

    public static readonly ExecutionResult1 Skipped = new("skipped");

    public static ExecutionResult1 FromValue(string value) => FromValueCore(value);
}
