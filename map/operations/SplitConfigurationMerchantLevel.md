<!-- Generated file — do not edit; regenerated with the SDK. -->

# SplitConfigurationMerchantLevel — operations

Accessor: `client.SplitConfigurationMerchantLevel` · Source: `src/Adyen/Api/SplitConfigurationMerchantLevel.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError` | `src/Adyen/Errors/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`, `RuleId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError` | `src/Adyen/Errors/DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdSplitConfigurations

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdSplitConfigurations(GetMerchantsMerchantIdSplitConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `SplitConfigurationList`
- **Error**: `ApiException<GetMerchantsMerchantIdSplitConfigurationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdSplitConfigurationsRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/GetMerchantsMerchantIdSplitConfigurationsRequest.cs` |
| `SplitConfigurationList` | `src/Adyen/Models/SplitConfigurationList.cs` |
| `GetMerchantsMerchantIdSplitConfigurationsError` | `src/Adyen/Errors/GetMerchantsMerchantIdSplitConfigurationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs` |
| `UpdateSplitConfigurationRequest` | `src/Adyen/Models/UpdateSplitConfigurationRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`, `RuleId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdRequest.cs` |
| `UpdateSplitConfigurationRuleRequest` | `src/Adyen/Models/UpdateSplitConfigurationRuleRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsSplitConfigurationsRulesSplitLogic

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsSplitConfigurationsRulesSplitLogic(PatchMerchantsSplitConfigurationsRulesSplitLogicRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`, `RuleId`, `SplitLogicId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<PatchMerchantsSplitConfigurationsRulesSplitLogicError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsSplitConfigurationsRulesSplitLogicRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/PatchMerchantsSplitConfigurationsRulesSplitLogicRequest.cs` |
| `UpdateSplitConfigurationLogicRequest` | `src/Adyen/Models/UpdateSplitConfigurationLogicRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `PatchMerchantsSplitConfigurationsRulesSplitLogicError` | `src/Adyen/Errors/PatchMerchantsSplitConfigurationsRulesSplitLogicError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdSplitConfigurations

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdSplitConfigurations(PostMerchantsMerchantIdSplitConfigurationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<PostMerchantsMerchantIdSplitConfigurationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdSplitConfigurationsRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/PostMerchantsMerchantIdSplitConfigurationsRequest.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `PostMerchantsMerchantIdSplitConfigurationsError` | `src/Adyen/Errors/PostMerchantsMerchantIdSplitConfigurationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `SplitConfigurationId`
- **Returns**: `SplitConfiguration`
- **Error**: `ApiException<PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest` | `src/Adyen/Requests/SplitConfigurationMerchantLevel/PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRequest.cs` |
| `SplitConfigurationRule` | `src/Adyen/Models/SplitConfigurationRule.cs` |
| `SplitConfiguration` | `src/Adyen/Models/SplitConfiguration.cs` |
| `PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError` | `src/Adyen/Errors/PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

