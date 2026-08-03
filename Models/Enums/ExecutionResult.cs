using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ExecutionResult>))]
public sealed record ExecutionResult : StringEnum<ExecutionResult>
{
    private ExecutionResult(string value) : base(value)
    {
    }

    public static readonly ExecutionResult Failed = new("failed");

    public static readonly ExecutionResult Succeeded = new("succeeded");

    public static readonly ExecutionResult Skipped = new("skipped");

    public static ExecutionResult FromValue(string value) => FromValueCore(value);
}
