<!-- Generated file — do not edit; regenerated with the SDK. -->

# CustomPayoutSchedulesSweeps — operations

Accessor: `client.CustomPayoutSchedulesSweeps` · Source: `src/Adyen/Api/CustomPayoutSchedulesSweeps.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBalanceAccountsBalanceAccountIdSweepsSweepId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteBalanceAccountsBalanceAccountIdSweepsSweepId(DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `SweepId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest` | `src/Adyen/Requests/CustomPayoutSchedulesSweeps/DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdRequest.cs` |
| `DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError` | `src/Adyen/Errors/DeleteBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetBalanceAccountsBalanceAccountIdSweeps

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalanceAccountsBalanceAccountIdSweeps(GetBalanceAccountsBalanceAccountIdSweepsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `BalanceSweepConfigurationsResponse`
- **Error**: `ApiException<GetBalanceAccountsBalanceAccountIdSweepsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsBalanceAccountIdSweepsRequest` | `src/Adyen/Requests/CustomPayoutSchedulesSweeps/GetBalanceAccountsBalanceAccountIdSweepsRequest.cs` |
| `BalanceSweepConfigurationsResponse` | `src/Adyen/Models/BalanceSweepConfigurationsResponse.cs` |
| `GetBalanceAccountsBalanceAccountIdSweepsError` | `src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdSweepsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetBalanceAccountsBalanceAccountIdSweepsSweepId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalanceAccountsBalanceAccountIdSweepsSweepId(GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `SweepId`
- **Returns**: `SweepConfigurationV2`
- **Error**: `ApiException<GetBalanceAccountsBalanceAccountIdSweepsSweepIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest` | `src/Adyen/Requests/CustomPayoutSchedulesSweeps/GetBalanceAccountsBalanceAccountIdSweepsSweepIdRequest.cs` |
| `SweepConfigurationV2` | `src/Adyen/Models/SweepConfigurationV2.cs` |
| `GetBalanceAccountsBalanceAccountIdSweepsSweepIdError` | `src/Adyen/Errors/GetBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchBalanceAccountsBalanceAccountIdSweepsSweepId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchBalanceAccountsBalanceAccountIdSweepsSweepId(PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`, `SweepId`
- **Returns**: `SweepConfigurationV2`
- **Error**: `ApiException<PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest` | `src/Adyen/Requests/CustomPayoutSchedulesSweeps/PatchBalanceAccountsBalanceAccountIdSweepsSweepIdRequest.cs` |
| `UpdateSweepConfigurationV2` | `src/Adyen/Models/UpdateSweepConfigurationV2.cs` |
| `SweepConfigurationV2` | `src/Adyen/Models/SweepConfigurationV2.cs` |
| `PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError` | `src/Adyen/Errors/PatchBalanceAccountsBalanceAccountIdSweepsSweepIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostBalanceAccountsBalanceAccountIdSweeps

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostBalanceAccountsBalanceAccountIdSweeps(PostBalanceAccountsBalanceAccountIdSweepsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalanceAccountId`
- **Returns**: `SweepConfigurationV2`
- **Error**: `ApiException<PostBalanceAccountsBalanceAccountIdSweepsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceAccountsBalanceAccountIdSweepsRequest` | `src/Adyen/Requests/CustomPayoutSchedulesSweeps/PostBalanceAccountsBalanceAccountIdSweepsRequest.cs` |
| `CreateSweepConfigurationV2` | `src/Adyen/Models/CreateSweepConfigurationV2.cs` |
| `SweepConfigurationV2` | `src/Adyen/Models/SweepConfigurationV2.cs` |
| `PostBalanceAccountsBalanceAccountIdSweepsError` | `src/Adyen/Errors/PostBalanceAccountsBalanceAccountIdSweepsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

