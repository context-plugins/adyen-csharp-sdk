using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchGrantsGrantIdDisbursementsDisbursementIdError : ApiError
{
    private readonly Optional<GrantsDisbursements404Error1> _grantsDisbursements404Error1Value;

    private readonly Optional<GrantsDisbursements422Error1> _grantsDisbursements422Error1Value;

    private PatchGrantsGrantIdDisbursementsDisbursementIdError(Optional<GrantsDisbursements404Error1> grantsDisbursements404Error1Value,
        Optional<GrantsDisbursements422Error1> grantsDisbursements422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _grantsDisbursements404Error1Value = grantsDisbursements404Error1Value;
        _grantsDisbursements422Error1Value = grantsDisbursements422Error1Value;
    }

    private static PatchGrantsGrantIdDisbursementsDisbursementIdError AsGrantsDisbursements404Error1(GrantsDisbursements404Error1 value) =>
        new(Optional<GrantsDisbursements404Error1>.Some(value), default, default);

    private static PatchGrantsGrantIdDisbursementsDisbursementIdError AsGrantsDisbursements422Error1(GrantsDisbursements422Error1 value) =>
        new(default, Optional<GrantsDisbursements422Error1>.Some(value), default);

    private static PatchGrantsGrantIdDisbursementsDisbursementIdError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetGrantsDisbursements404Error1(out GrantsDisbursements404Error1 value) =>
        _grantsDisbursements404Error1Value.TryGetValue(out value);

    public bool TryGetGrantsDisbursements422Error1(out GrantsDisbursements422Error1 value) =>
        _grantsDisbursements422Error1Value.TryGetValue(out value);

    internal static Task<PatchGrantsGrantIdDisbursementsDisbursementIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<GrantsDisbursements404Error1>(response, ct).As(AsGrantsDisbursements404Error1),
            422 => FromJson<GrantsDisbursements422Error1>(response, ct).As(AsGrantsDisbursements422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse : IErrorResponse<PatchGrantsGrantIdDisbursementsDisbursementIdError>
{
    public static PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse Instance { get; } = new();

    private PatchGrantsGrantIdDisbursementsDisbursementIdErrorResponse()
    {
    }

    public Task<PatchGrantsGrantIdDisbursementsDisbursementIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => PatchGrantsGrantIdDisbursementsDisbursementIdError.Create(response, ct);
}
