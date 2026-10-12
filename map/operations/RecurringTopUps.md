<!-- Generated file — do not edit; regenerated with the SDK. -->

# RecurringTopUps — operations

Accessor: `client.RecurringTopUps` · Source: `src/Adyen/Api/RecurringTopUps.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId

- **Server group**: `Default13`
- **Signature**: `DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `TopUpId`
- **Returns**: `JsonElement`
- **Error**: `ApiException<DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest` | `src/Adyen/Requests/RecurringTopUps/DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest.cs` |
| `DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError` | `src/Adyen/Errors/DeleteBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsBalanceAccountIdRecurringTopUps

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsBalanceAccountIdRecurringTopUps(GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`
- **Query params (wire ← C#)**: `limit` ← `Limit`, `cursor` ← `Cursor`
- **Returns**: `RecurringTopUpsResult`
- **Error**: `ApiException<GetBalanceAccountsBalanceAccountIdRecurringTopUpsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest` | `src/Adyen/Requests/RecurringTopUps/GetBalanceAccountsBalanceAccountIdRecurringTopUpsRequest.cs` |
| `RecurringTopUpsResult` | `src/Adyen/Models/RecurringTopUpsResult.cs` |
| `GetBalanceAccountsBalanceAccountIdRecurringTopUpsError` | `src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdRecurringTopUpsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId

- **Server group**: `Default13`
- **Signature**: `PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpId(PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `TopUpId`, `Body`
- **Returns**: `RecurringTopUp`
- **Error**: `ApiException<PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest` | `src/Adyen/Requests/RecurringTopUps/PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdRequest.cs` |
| `PatchableCreateRecurringTopUp` | `src/Adyen/Models/PatchableCreateRecurringTopUp.cs` |
| `RecurringTopUp` | `src/Adyen/Models/RecurringTopUp.cs` |
| `PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError` | `src/Adyen/Errors/PatchBalanceAccountsBalanceAccountIdRecurringTopUpsTopUpIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostBalanceAccountsBalanceAccountIdRecurringTopUps

- **Server group**: `Default13`
- **Signature**: `PostBalanceAccountsBalanceAccountIdRecurringTopUps(PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `Body`
- **Returns**: `RecurringTopUp`
- **Error**: `ApiException<PostBalanceAccountsBalanceAccountIdRecurringTopUpsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest` | `src/Adyen/Requests/RecurringTopUps/PostBalanceAccountsBalanceAccountIdRecurringTopUpsRequest.cs` |
| `CreateRecurringTopUp` | `src/Adyen/Models/CreateRecurringTopUp.cs` |
| `RecurringTopUp` | `src/Adyen/Models/RecurringTopUp.cs` |
| `PostBalanceAccountsBalanceAccountIdRecurringTopUpsError` | `src/Adyen/Errors/PostBalanceAccountsBalanceAccountIdRecurringTopUpsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

