<!-- Generated file — do not edit; regenerated with the SDK. -->

# Balances — operations

Accessor: `client.Balances` · Source: `src/Adyen/Api/Balances.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId

- **Server group**: `Default13`
- **Signature**: `DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`, `WebhookId`, `SettingId`
- **Returns**: `JsonElement`
- **Error**: `ApiException<DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest` | `src/Adyen/Requests/Balances/DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest.cs` |
| `DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError` | `src/Adyen/Errors/DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings

- **Server group**: `Default13`
- **Signature**: `GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`, `WebhookId`
- **Returns**: `WebhookSettings`
- **Error**: `ApiException<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest` | `src/Adyen/Requests/Balances/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest.cs` |
| `WebhookSettings` | `src/Adyen/Models/WebhookSettings.cs` |
| `GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError` | `src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId

- **Server group**: `Default13`
- **Signature**: `GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`, `WebhookId`, `SettingId`
- **Returns**: `WebhookSetting`
- **Error**: `ApiException<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest` | `src/Adyen/Requests/Balances/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest.cs` |
| `WebhookSetting` | `src/Adyen/Models/WebhookSetting.cs` |
| `GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError` | `src/Adyen/Errors/GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId

- **Server group**: `Default13`
- **Signature**: `PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`, `WebhookId`, `SettingId`, `Body`
- **Returns**: `WebhookSetting`
- **Error**: `ApiException<PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest` | `src/Adyen/Requests/Balances/PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest.cs` |
| `BalanceWebhookSettingInfoUpdate` | `src/Adyen/Models/BalanceWebhookSettingInfoUpdate.cs` |
| `WebhookSetting` | `src/Adyen/Models/WebhookSetting.cs` |
| `PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError` | `src/Adyen/Errors/PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings

- **Server group**: `Default13`
- **Signature**: `PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `BalancePlatformId`, `WebhookId`, `Body`
- **Returns**: `WebhookSetting`
- **Error**: `ApiException<PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest` | `src/Adyen/Requests/Balances/PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest.cs` |
| `BalanceWebhookSettingInfo` | `src/Adyen/Models/BalanceWebhookSettingInfo.cs` |
| `WebhookSetting` | `src/Adyen/Models/WebhookSetting.cs` |
| `PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError` | `src/Adyen/Errors/PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

