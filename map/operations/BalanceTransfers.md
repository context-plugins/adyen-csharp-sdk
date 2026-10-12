<!-- Generated file — do not edit; regenerated with the SDK. -->

# BalanceTransfers — operations

Accessor: `client.BalanceTransfers` · Source: `src/Adyen/Api/BalanceTransfers.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostBalanceTransfers

- **Server group**: `Default11`
- **Signature**: `PostBalanceTransfers(PostBalanceTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `BalanceTransferResponse`
- **Error**: `ApiException<PostBalanceTransfersError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceTransfersRequest` | `src/Adyen/Requests/BalanceTransfers/PostBalanceTransfersRequest.cs` |
| `BalanceTransferRequest` | `src/Adyen/Models/BalanceTransferRequest.cs` |
| `BalanceTransferResponse` | `src/Adyen/Models/BalanceTransferResponse.cs` |
| `PostBalanceTransfersError` | `src/Adyen/Errors/PostBalanceTransfersError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

