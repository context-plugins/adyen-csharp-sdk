using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMandatesMandateIdError : ApiError
{
    private readonly Optional<Mandates401Error1> _mandates401Error1Value;

    private readonly Optional<Mandates403Error1> _mandates403Error1Value;

    private readonly Optional<Mandates404Error1> _mandates404Error1Value;

    private readonly Optional<Mandates422Error1> _mandates422Error1Value;

    private readonly Optional<Mandates500Error1> _mandates500Error1Value;

    private GetMandatesMandateIdError(Optional<Mandates401Error1> mandates401Error1Value,
        Optional<Mandates403Error1> mandates403Error1Value,
        Optional<Mandates404Error1> mandates404Error1Value,
        Optional<Mandates422Error1> mandates422Error1Value,
        Optional<Mandates500Error1> mandates500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _mandates401Error1Value = mandates401Error1Value;
        _mandates403Error1Value = mandates403Error1Value;
        _mandates404Error1Value = mandates404Error1Value;
        _mandates422Error1Value = mandates422Error1Value;
        _mandates500Error1Value = mandates500Error1Value;
    }

    private static GetMandatesMandateIdError AsMandates401Error1(Mandates401Error1 value) =>
        new(Optional<Mandates401Error1>.Some(value), default, default, default, default, default);

    private static GetMandatesMandateIdError AsMandates403Error1(Mandates403Error1 value) =>
        new(default, Optional<Mandates403Error1>.Some(value), default, default, default, default);

    private static GetMandatesMandateIdError AsMandates404Error1(Mandates404Error1 value) =>
        new(default, default, Optional<Mandates404Error1>.Some(value), default, default, default);

    private static GetMandatesMandateIdError AsMandates422Error1(Mandates422Error1 value) =>
        new(default, default, default, Optional<Mandates422Error1>.Some(value), default, default);

    private static GetMandatesMandateIdError AsMandates500Error1(Mandates500Error1 value) =>
        new(default, default, default, default, Optional<Mandates500Error1>.Some(value), default);

    private static GetMandatesMandateIdError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMandates401Error1(out Mandates401Error1 value) =>
        _mandates401Error1Value.TryGetValue(out value);

    public bool TryGetMandates403Error1(out Mandates403Error1 value) =>
        _mandates403Error1Value.TryGetValue(out value);

    public bool TryGetMandates404Error1(out Mandates404Error1 value) =>
        _mandates404Error1Value.TryGetValue(out value);

    public bool TryGetMandates422Error1(out Mandates422Error1 value) =>
        _mandates422Error1Value.TryGetValue(out value);

    public bool TryGetMandates500Error1(out Mandates500Error1 value) =>
        _mandates500Error1Value.TryGetValue(out value);

    internal static Task<GetMandatesMandateIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Mandates401Error1>(response, ct).As(AsMandates401Error1),
            403 => FromJson<Mandates403Error1>(response, ct).As(AsMandates403Error1),
            404 => FromJson<Mandates404Error1>(response, ct).As(AsMandates404Error1),
            422 => FromJson<Mandates422Error1>(response, ct).As(AsMandates422Error1),
            500 => FromJson<Mandates500Error1>(response, ct).As(AsMandates500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMandatesMandateIdErrorResponse : IErrorResponse<GetMandatesMandateIdError>
{
    public static GetMandatesMandateIdErrorResponse Instance { get; } = new();

    private GetMandatesMandateIdErrorResponse()
    {
    }

    public Task<GetMandatesMandateIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetMandatesMandateIdError.Create(response, ct);
}
