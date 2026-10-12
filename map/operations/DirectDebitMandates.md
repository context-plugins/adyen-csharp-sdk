<!-- Generated file — do not edit; regenerated with the SDK. -->

# DirectDebitMandates — operations

Accessor: `client.DirectDebitMandates` · Source: `src/Adyen/Api/DirectDebitMandates.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMandates

- **Server group**: `Default13`
- **Signature**: `GetMandates(GetMandatesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `balanceAccountId` ← `BalanceAccountId`, `paymentInstrumentId` ← `PaymentInstrumentId`, `cursor` ← `Cursor`
- **Returns**: `ListMandatesResponse`
- **Error**: `ApiException<GetMandatesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMandatesRequest` | `src/Adyen/Requests/DirectDebitMandates/GetMandatesRequest.cs` |
| `ListMandatesResponse` | `src/Adyen/Models/ListMandatesResponse.cs` |
| `GetMandatesError` | `src/Adyen/Errors/GetMandatesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetMandatesMandateId

- **Server group**: `Default13`
- **Signature**: `GetMandatesMandateId(GetMandatesMandateIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MandateId`
- **Returns**: `Mandate1`
- **Error**: `ApiException<GetMandatesMandateIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMandatesMandateIdRequest` | `src/Adyen/Requests/DirectDebitMandates/GetMandatesMandateIdRequest.cs` |
| `Mandate1` | `src/Adyen/Models/Mandate1.cs` |
| `GetMandatesMandateIdError` | `src/Adyen/Errors/GetMandatesMandateIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchMandatesMandateId

- **Server group**: `Default13`
- **Signature**: `PatchMandatesMandateId(PatchMandatesMandateIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MandateId`, `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchMandatesMandateIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMandatesMandateIdRequest` | `src/Adyen/Requests/DirectDebitMandates/PatchMandatesMandateIdRequest.cs` |
| `MandateUpdate` | `src/Adyen/Models/MandateUpdate.cs` |
| `PatchMandatesMandateIdError` | `src/Adyen/Errors/PatchMandatesMandateIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostMandatesMandateIdCancel

- **Server group**: `Default13`
- **Signature**: `PostMandatesMandateIdCancel(PostMandatesMandateIdCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MandateId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostMandatesMandateIdCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMandatesMandateIdCancelRequest` | `src/Adyen/Requests/DirectDebitMandates/PostMandatesMandateIdCancelRequest.cs` |
| `PostMandatesMandateIdCancelError` | `src/Adyen/Errors/PostMandatesMandateIdCancelError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

