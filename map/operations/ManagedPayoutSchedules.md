<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManagedPayoutSchedules — operations

Accessor: `client.ManagedPayoutSchedules` · Source: `src/Adyen/Api/ManagedPayoutSchedules.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId

- **Server group**: `Default13`
- **Signature**: `DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesId(DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest.cs` |
| `DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError` | `src/Adyen/Errors/DeleteBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsBalanceAccountIdPayoutSchedules

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsBalanceAccountIdPayoutSchedules(GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`
- **Query params (wire ← C#)**: `currency` ← `Currency`, `cursor` ← `Cursor`, `limit` ← `Limit`
- **Returns**: `BalanceAccountConfigurations`
- **Error**: `ApiException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/GetBalanceAccountsBalanceAccountIdPayoutSchedulesRequest.cs` |
| `BalanceAccountConfigurations` | `src/Adyen/Models/BalanceAccountConfigurations.cs` |
| `GetBalanceAccountsBalanceAccountIdPayoutSchedulesError` | `src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsBalanceAccountIdPayoutSchedulesId

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsBalanceAccountIdPayoutSchedulesId(GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `Id`
- **Returns**: `BalanceAccountConfiguration`
- **Error**: `ApiException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest.cs` |
| `BalanceAccountConfiguration` | `src/Adyen/Models/BalanceAccountConfiguration.cs` |
| `GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError` | `src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutions(GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `Id`, `Offset`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `results` ← `Results`, `limit` ← `Limit`
- **Returns**: `PayoutScheduleExecutions`
- **Error**: `ApiException<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsRequest.cs` |
| `ExecutionResult` | `src/Adyen/Models/Enums/ExecutionResult.cs` |
| `PayoutScheduleExecutions` | `src/Adyen/Models/PayoutScheduleExecutions.cs` |
| `GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError` | `src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalancePlatformsBalancePlatformIdPayoutSchedules

- **Server group**: `Default13`
- **Signature**: `GetBalancePlatformsBalancePlatformIdPayoutSchedules(GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`
- **Query params (wire ← C#)**: `countryCode` ← `CountryCode`, `currency` ← `Currency`
- **Returns**: `BalancePlatformConfigurations`
- **Error**: `ApiException<GetBalancePlatformsBalancePlatformIdPayoutSchedulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest.cs` |
| `BalancePlatformConfigurations` | `src/Adyen/Models/BalancePlatformConfigurations.cs` |
| `GetBalancePlatformsBalancePlatformIdPayoutSchedulesError` | `src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdPayoutSchedulesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalancePlatformsBalancePlatformIdPayoutSchedulesId

- **Server group**: `Default13`
- **Signature**: `GetBalancePlatformsBalancePlatformIdPayoutSchedulesId(GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`, `Id`
- **Returns**: `BalancePlatformConfiguration`
- **Error**: `ApiException<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdRequest.cs` |
| `BalancePlatformConfiguration` | `src/Adyen/Models/BalancePlatformConfiguration.cs` |
| `GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError` | `src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId

- **Server group**: `Default13`
- **Signature**: `PatchBalanceAccountsBalanceAccountIdPayoutSchedulesId(PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `Id`, `Body`
- **Returns**: `BalanceAccountConfiguration`
- **Error**: `ApiException<PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdRequest.cs` |
| `BalanceAccountConfigurationUpdate` | `src/Adyen/Models/BalanceAccountConfigurationUpdate.cs` |
| `BalanceAccountConfiguration` | `src/Adyen/Models/BalanceAccountConfiguration.cs` |
| `PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError` | `src/Adyen/Errors/PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostBalanceAccountsBalanceAccountIdPayoutSchedules

- **Server group**: `Default13`
- **Signature**: `PostBalanceAccountsBalanceAccountIdPayoutSchedules(PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `Body`
- **Returns**: `BalanceAccountConfiguration`
- **Error**: `ApiException<PostBalanceAccountsBalanceAccountIdPayoutSchedulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest` | `src/Adyen/Requests/ManagedPayoutSchedules/PostBalanceAccountsBalanceAccountIdPayoutSchedulesRequest.cs` |
| `BalanceAccountConfigurationRequest` | `src/Adyen/Models/BalanceAccountConfigurationRequest.cs` |
| `BalanceAccountConfiguration` | `src/Adyen/Models/BalanceAccountConfiguration.cs` |
| `PostBalanceAccountsBalanceAccountIdPayoutSchedulesError` | `src/Adyen/Errors/PostBalanceAccountsBalanceAccountIdPayoutSchedulesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

