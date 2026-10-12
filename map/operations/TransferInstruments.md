<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferInstruments — operations

Accessor: `client.TransferInstruments` · Source: `src/Adyen/Api/TransferInstruments.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTransferInstrumentsId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteTransferInstrumentsId(DeleteTransferInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteTransferInstrumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTransferInstrumentsIdRequest` | `src/Adyen/Requests/TransferInstruments/DeleteTransferInstrumentsIdRequest.cs` |
| `DeleteTransferInstrumentsIdError` | `src/Adyen/Errors/DeleteTransferInstrumentsIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetTransferInstrumentsId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTransferInstrumentsId(GetTransferInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransferInstrument`
- **Error**: `ApiException<GetTransferInstrumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransferInstrumentsIdRequest` | `src/Adyen/Requests/TransferInstruments/GetTransferInstrumentsIdRequest.cs` |
| `TransferInstrument` | `src/Adyen/Models/TransferInstrument.cs` |
| `GetTransferInstrumentsIdError` | `src/Adyen/Errors/GetTransferInstrumentsIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PatchTransferInstrumentsId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchTransferInstrumentsId(PatchTransferInstrumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransferInstrument`
- **Error**: `ApiException<PatchTransferInstrumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchTransferInstrumentsIdRequest` | `src/Adyen/Requests/TransferInstruments/PatchTransferInstrumentsIdRequest.cs` |
| `TransferInstrumentInfo` | `src/Adyen/Models/TransferInstrumentInfo.cs` |
| `TransferInstrument` | `src/Adyen/Models/TransferInstrument.cs` |
| `PatchTransferInstrumentsIdError` | `src/Adyen/Errors/PatchTransferInstrumentsIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostTransferInstruments

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransferInstruments(PostTransferInstrumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TransferInstrument`
- **Error**: `ApiException<PostTransferInstrumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransferInstrumentsRequest` | `src/Adyen/Requests/TransferInstruments/PostTransferInstrumentsRequest.cs` |
| `TransferInstrumentInfo` | `src/Adyen/Models/TransferInstrumentInfo.cs` |
| `TransferInstrument` | `src/Adyen/Models/TransferInstrument.cs` |
| `PostTransferInstrumentsError` | `src/Adyen/Errors/PostTransferInstrumentsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

