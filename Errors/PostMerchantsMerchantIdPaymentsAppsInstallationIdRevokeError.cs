using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError : ApiError
{
    private readonly Optional<MerchantsPaymentsAppsRevoke400Error1> _merchantsPaymentsAppsRevoke400Error1Value;

    private readonly Optional<MerchantsPaymentsAppsRevoke401Error1> _merchantsPaymentsAppsRevoke401Error1Value;

    private readonly Optional<MerchantsPaymentsAppsRevoke500Error1> _merchantsPaymentsAppsRevoke500Error1Value;

    private PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError(Optional<MerchantsPaymentsAppsRevoke400Error1> merchantsPaymentsAppsRevoke400Error1Value,
        Optional<MerchantsPaymentsAppsRevoke401Error1> merchantsPaymentsAppsRevoke401Error1Value,
        Optional<MerchantsPaymentsAppsRevoke500Error1> merchantsPaymentsAppsRevoke500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsPaymentsAppsRevoke400Error1Value = merchantsPaymentsAppsRevoke400Error1Value;
        _merchantsPaymentsAppsRevoke401Error1Value = merchantsPaymentsAppsRevoke401Error1Value;
        _merchantsPaymentsAppsRevoke500Error1Value = merchantsPaymentsAppsRevoke500Error1Value;
    }

    private static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError AsMerchantsPaymentsAppsRevoke400Error1(MerchantsPaymentsAppsRevoke400Error1 value) =>
        new(Optional<MerchantsPaymentsAppsRevoke400Error1>.Some(value), default, default, default);

    private static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError AsMerchantsPaymentsAppsRevoke401Error1(MerchantsPaymentsAppsRevoke401Error1 value) =>
        new(default, Optional<MerchantsPaymentsAppsRevoke401Error1>.Some(value), default, default);

    private static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError AsMerchantsPaymentsAppsRevoke500Error1(MerchantsPaymentsAppsRevoke500Error1 value) =>
        new(default, default, Optional<MerchantsPaymentsAppsRevoke500Error1>.Some(value), default);

    private static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsPaymentsAppsRevoke400Error1(out MerchantsPaymentsAppsRevoke400Error1 value) =>
        _merchantsPaymentsAppsRevoke400Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsPaymentsAppsRevoke401Error1(out MerchantsPaymentsAppsRevoke401Error1 value) =>
        _merchantsPaymentsAppsRevoke401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsPaymentsAppsRevoke500Error1(out MerchantsPaymentsAppsRevoke500Error1 value) =>
        _merchantsPaymentsAppsRevoke500Error1Value.TryGetValue(out value);

    internal static Task<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<MerchantsPaymentsAppsRevoke400Error1>(response, ct).As(AsMerchantsPaymentsAppsRevoke400Error1),
            401 => FromJson<MerchantsPaymentsAppsRevoke401Error1>(response, ct).As(AsMerchantsPaymentsAppsRevoke401Error1),
            500 => FromJson<MerchantsPaymentsAppsRevoke500Error1>(response, ct).As(AsMerchantsPaymentsAppsRevoke500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse : IErrorResponse<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError>
{
    public static PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse Instance { get; } = new();

    private PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeErrorResponse()
    {
    }

    public Task<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError.Create(response, ct);
}
