<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferRoutes — operations

Accessor: `client.TransferRoutes` · Source: `src/Adyen/Api/TransferRoutes.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostTransferRoutesCalculate

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransferRoutesCalculate(PostTransferRoutesCalculateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TransferRouteResponse`
- **Error**: `ApiException<PostTransferRoutesCalculateError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransferRoutesCalculateRequest` | `src/Adyen/Requests/TransferRoutes/PostTransferRoutesCalculateRequest.cs` |
| `TransferRouteRequest` | `src/Adyen/Models/TransferRouteRequest.cs` |
| `TransferRouteResponse` | `src/Adyen/Models/TransferRouteResponse.cs` |
| `PostTransferRoutesCalculateError` | `src/Adyen/Errors/PostTransferRoutesCalculateError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

