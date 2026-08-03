using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetDisputesIdError : ApiError
{
    private readonly Optional<Disputes401Error1> _disputes401Error1Value;

    private readonly Optional<Disputes403Error1> _disputes403Error1Value;

    private readonly Optional<Disputes422Error1> _disputes422Error1Value;

    private GetDisputesIdError(Optional<Disputes401Error1> disputes401Error1Value,
        Optional<Disputes403Error1> disputes403Error1Value,
        Optional<Disputes422Error1> disputes422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _disputes401Error1Value = disputes401Error1Value;
        _disputes403Error1Value = disputes403Error1Value;
        _disputes422Error1Value = disputes422Error1Value;
    }

    private static GetDisputesIdError AsDisputes401Error1(Disputes401Error1 value) =>
        new(Optional<Disputes401Error1>.Some(value), default, default, default);

    private static GetDisputesIdError AsDisputes403Error1(Disputes403Error1 value) =>
        new(default, Optional<Disputes403Error1>.Some(value), default, default);

    private static GetDisputesIdError AsDisputes422Error1(Disputes422Error1 value) =>
        new(default, default, Optional<Disputes422Error1>.Some(value), default);

    private static GetDisputesIdError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDisputes401Error1(out Disputes401Error1 value) =>
        _disputes401Error1Value.TryGetValue(out value);

    public bool TryGetDisputes403Error1(out Disputes403Error1 value) =>
        _disputes403Error1Value.TryGetValue(out value);

    public bool TryGetDisputes422Error1(out Disputes422Error1 value) =>
        _disputes422Error1Value.TryGetValue(out value);

    internal static Task<GetDisputesIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Disputes401Error1>(response, ct).As(AsDisputes401Error1),
            403 => FromJson<Disputes403Error1>(response, ct).As(AsDisputes403Error1),
            422 => FromJson<Disputes422Error1>(response, ct).As(AsDisputes422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDisputesIdErrorResponse : IErrorResponse<GetDisputesIdError>
{
    public static GetDisputesIdErrorResponse Instance { get; } = new();

    private GetDisputesIdErrorResponse()
    {
    }

    public Task<GetDisputesIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDisputesIdError.Create(response, ct);
}
