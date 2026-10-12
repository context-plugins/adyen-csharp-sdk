<!-- Generated file — do not edit; regenerated with the SDK. -->

# Transfers — operations

Accessor: `client.Transfers` · Source: `src/Adyen/Api/Transfers.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTransfers

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTransfers(GetTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CreatedSince`, `CreatedUntil`
- **Query params (wire ← C#)**: `createdSince` ← `CreatedSince`, `createdUntil` ← `CreatedUntil`, `balancePlatform` ← `BalancePlatform`, `accountHolderId` ← `AccountHolderId`, `balanceAccountId` ← `BalanceAccountId`, `paymentInstrumentId` ← `PaymentInstrumentId`, `reference` ← `Reference`, `category` ← `Category`, `sortOrder` ← `SortOrder`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `FindTransfersResponse`
- **Error**: `ApiException<GetTransfersError>` — **Case A (typed)**
- **Error accessors**: `TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransfersRequest` | `src/Adyen/Requests/Transfers/GetTransfersRequest.cs` |
| `Category2` | `src/Adyen/Models/Enums/Category2.cs` |
| `SortOrder` | `src/Adyen/Models/Enums/SortOrder.cs` |
| `FindTransfersResponse` | `src/Adyen/Models/FindTransfersResponse.cs` |
| `GetTransfersError` | `src/Adyen/Errors/GetTransfersError.cs` |
| `TransferServiceRestServiceError` | `src/Adyen/Models/TransferServiceRestServiceError.cs` |

### GetTransfersId

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTransfersId(GetTransfersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransferData`
- **Error**: `ApiException<GetTransfersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransfersIdRequest` | `src/Adyen/Requests/Transfers/GetTransfersIdRequest.cs` |
| `TransferData` | `src/Adyen/Models/TransferData.cs` |
| `GetTransfersIdError` | `src/Adyen/Errors/GetTransfersIdError.cs` |
| `TransferServiceRestServiceError` | `src/Adyen/Models/TransferServiceRestServiceError.cs` |

### PostTransfers

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransfers(PostTransfersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Transfer`
- **Error**: `ApiException<PostTransfersError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [401] · `TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError)` [403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransfersRequest` | `src/Adyen/Requests/Transfers/PostTransfersRequest.cs` |
| `TransferInfo` | `src/Adyen/Models/TransferInfo.cs` |
| `Transfer` | `src/Adyen/Models/Transfer.cs` |
| `PostTransfersError` | `src/Adyen/Errors/PostTransfersError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |
| `TransferServiceRestServiceError` | `src/Adyen/Models/TransferServiceRestServiceError.cs` |

### PostTransfersApprove

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransfersApprove(PostTransfersApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `JsonElement`
- **Error**: `ApiException<PostTransfersApproveError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [401] · `TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError)` [403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransfersApproveRequest` | `src/Adyen/Requests/Transfers/PostTransfersApproveRequest.cs` |
| `ApproveTransfersRequest` | `src/Adyen/Models/ApproveTransfersRequest.cs` |
| `PostTransfersApproveError` | `src/Adyen/Errors/PostTransfersApproveError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |
| `TransferServiceRestServiceError` | `src/Adyen/Models/TransferServiceRestServiceError.cs` |

### PostTransfersCancel

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransfersCancel(PostTransfersCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `JsonElement`
- **Error**: `ApiException<PostTransfersCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransfersCancelRequest` | `src/Adyen/Requests/Transfers/PostTransfersCancelRequest.cs` |
| `CancelTransfersRequest` | `src/Adyen/Models/CancelTransfersRequest.cs` |
| `PostTransfersCancelError` | `src/Adyen/Errors/PostTransfersCancelError.cs` |
| `TransferServiceRestServiceError` | `src/Adyen/Models/TransferServiceRestServiceError.cs` |

### PostTransfersTransferIdReturns

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransfersTransferIdReturns(PostTransfersTransferIdReturnsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransferId`
- **Returns**: `ReturnTransferResponse`
- **Error**: `ApiException<PostTransfersTransferIdReturnsError>` — **Case A (typed)**
- **Error accessors**: `TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransfersTransferIdReturnsRequest` | `src/Adyen/Requests/Transfers/PostTransfersTransferIdReturnsRequest.cs` |
| `ReturnTransferRequest` | `src/Adyen/Models/ReturnTransferRequest.cs` |
| `ReturnTransferResponse` | `src/Adyen/Models/ReturnTransferResponse.cs` |
| `PostTransfersTransferIdReturnsError` | `src/Adyen/Errors/PostTransfersTransferIdReturnsError.cs` |
| `TransferServiceRestServiceError` | `src/Adyen/Models/TransferServiceRestServiceError.cs` |

