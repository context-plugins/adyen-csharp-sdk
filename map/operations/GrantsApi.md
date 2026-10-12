<!-- Generated file — do not edit; regenerated with the SDK. -->

# GrantsApi — operations

Accessor: `client.GrantsApi` · Source: `src/Adyen/Api/GrantsApi.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetGrants2

- **Server group**: `Default15`
- **Signature**: `GetGrants2(GetGrants2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CounterpartyAccountHolderId`
- **Query params (wire ← C#)**: `counterpartyAccountHolderId` ← `CounterpartyAccountHolderId`
- **Returns**: `Grants`
- **Error**: `ApiException<GetGrants2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrants2Request` | `src/Adyen/Requests/GrantsApi/GetGrants2Request.cs` |
| `Grants` | `src/Adyen/Models/Grants.cs` |
| `GetGrants2Error` | `src/Adyen/Errors/GetGrants2Error.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetGrantsGrantId

- **Server group**: `Default15`
- **Signature**: `GetGrantsGrantId(GetGrantsGrantIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GrantId`
- **Returns**: `Grant`
- **Error**: `ApiException<GetGrantsGrantIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantsGrantIdRequest` | `src/Adyen/Requests/GrantsApi/GetGrantsGrantIdRequest.cs` |
| `Grant` | `src/Adyen/Models/Grant.cs` |
| `GetGrantsGrantIdError` | `src/Adyen/Errors/GetGrantsGrantIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetGrantsGrantIdDisbursements

- **Server group**: `Default15`
- **Signature**: `GetGrantsGrantIdDisbursements(GetGrantsGrantIdDisbursementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GrantId`
- **Returns**: `Disbursements`
- **Error**: `ApiException<GetGrantsGrantIdDisbursementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantsGrantIdDisbursementsRequest` | `src/Adyen/Requests/GrantsApi/GetGrantsGrantIdDisbursementsRequest.cs` |
| `Disbursements` | `src/Adyen/Models/Disbursements.cs` |
| `GetGrantsGrantIdDisbursementsError` | `src/Adyen/Errors/GetGrantsGrantIdDisbursementsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetGrantsGrantIdDisbursementsDisbursementId

- **Server group**: `Default15`
- **Signature**: `GetGrantsGrantIdDisbursementsDisbursementId(GetGrantsGrantIdDisbursementsDisbursementIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GrantId`, `DisbursementId`
- **Returns**: `Disbursement`
- **Error**: `ApiException<GetGrantsGrantIdDisbursementsDisbursementIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantsGrantIdDisbursementsDisbursementIdRequest` | `src/Adyen/Requests/GrantsApi/GetGrantsGrantIdDisbursementsDisbursementIdRequest.cs` |
| `Disbursement` | `src/Adyen/Models/Disbursement.cs` |
| `GetGrantsGrantIdDisbursementsDisbursementIdError` | `src/Adyen/Errors/GetGrantsGrantIdDisbursementsDisbursementIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchGrantsGrantIdDisbursementsDisbursementId

- **Server group**: `Default15`
- **Signature**: `PatchGrantsGrantIdDisbursementsDisbursementId(PatchGrantsGrantIdDisbursementsDisbursementIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `GrantId`, `DisbursementId`, `Body`
- **Returns**: `Disbursement`
- **Error**: `ApiException<PatchGrantsGrantIdDisbursementsDisbursementIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchGrantsGrantIdDisbursementsDisbursementIdRequest` | `src/Adyen/Requests/GrantsApi/PatchGrantsGrantIdDisbursementsDisbursementIdRequest.cs` |
| `DisbursementInfoUpdate` | `src/Adyen/Models/DisbursementInfoUpdate.cs` |
| `Disbursement` | `src/Adyen/Models/Disbursement.cs` |
| `PatchGrantsGrantIdDisbursementsDisbursementIdError` | `src/Adyen/Errors/PatchGrantsGrantIdDisbursementsDisbursementIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostGrants2

- **Server group**: `Default15`
- **Signature**: `PostGrants2(PostGrants2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Grant`
- **Error**: `ApiException<PostGrants2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGrants2Request` | `src/Adyen/Requests/GrantsApi/PostGrants2Request.cs` |
| `CapitalGrantInfo` | `src/Adyen/Models/CapitalGrantInfo.cs` |
| `Grant` | `src/Adyen/Models/Grant.cs` |
| `PostGrants2Error` | `src/Adyen/Errors/PostGrants2Error.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

