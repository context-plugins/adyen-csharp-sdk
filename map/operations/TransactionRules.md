<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionRules — operations

Accessor: `client.TransactionRules` · Source: `src/Adyen/Api/TransactionRules.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteTransactionRulesTransactionRuleId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteTransactionRulesTransactionRuleId(DeleteTransactionRulesTransactionRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionRuleId`
- **Returns**: `TransactionRule`
- **Error**: `ApiException<DeleteTransactionRulesTransactionRuleIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTransactionRulesTransactionRuleIdRequest` | `src/Adyen/Requests/TransactionRules/DeleteTransactionRulesTransactionRuleIdRequest.cs` |
| `TransactionRule` | `src/Adyen/Models/TransactionRule.cs` |
| `DeleteTransactionRulesTransactionRuleIdError` | `src/Adyen/Errors/DeleteTransactionRulesTransactionRuleIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetTransactionRulesTransactionRuleId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTransactionRulesTransactionRuleId(GetTransactionRulesTransactionRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionRuleId`
- **Returns**: `TransactionRuleResponse`
- **Error**: `ApiException<GetTransactionRulesTransactionRuleIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionRulesTransactionRuleIdRequest` | `src/Adyen/Requests/TransactionRules/GetTransactionRulesTransactionRuleIdRequest.cs` |
| `TransactionRuleResponse` | `src/Adyen/Models/TransactionRuleResponse.cs` |
| `GetTransactionRulesTransactionRuleIdError` | `src/Adyen/Errors/GetTransactionRulesTransactionRuleIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchTransactionRulesTransactionRuleId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchTransactionRulesTransactionRuleId(PatchTransactionRulesTransactionRuleIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TransactionRuleId`
- **Returns**: `TransactionRule`
- **Error**: `ApiException<PatchTransactionRulesTransactionRuleIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchTransactionRulesTransactionRuleIdRequest` | `src/Adyen/Requests/TransactionRules/PatchTransactionRulesTransactionRuleIdRequest.cs` |
| `TransactionRuleInfo` | `src/Adyen/Models/TransactionRuleInfo.cs` |
| `TransactionRule` | `src/Adyen/Models/TransactionRule.cs` |
| `PatchTransactionRulesTransactionRuleIdError` | `src/Adyen/Errors/PatchTransactionRulesTransactionRuleIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostTransactionRules

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTransactionRules(PostTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TransactionRule`
- **Error**: `ApiException<PostTransactionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTransactionRulesRequest` | `src/Adyen/Requests/TransactionRules/PostTransactionRulesRequest.cs` |
| `TransactionRuleInfo` | `src/Adyen/Models/TransactionRuleInfo.cs` |
| `TransactionRule` | `src/Adyen/Models/TransactionRule.cs` |
| `PostTransactionRulesError` | `src/Adyen/Errors/PostTransactionRulesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

