<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalActionsTerminalLevel — operations

Accessor: `client.TerminalActionsTerminalLevel` · Source: `src/Adyen/Api/TerminalActionsTerminalLevel.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostTerminalsScheduleActions

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTerminalsScheduleActions(PostTerminalsScheduleActionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ScheduleTerminalActionsResponse`
- **Error**: `ApiException<PostTerminalsScheduleActionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalsScheduleActionsRequest` | `src/Adyen/Requests/TerminalActionsTerminalLevel/PostTerminalsScheduleActionsRequest.cs` |
| `ScheduleTerminalActionsRequest` | `src/Adyen/Models/ScheduleTerminalActionsRequest.cs` |
| `ScheduleTerminalActionsResponse` | `src/Adyen/Models/ScheduleTerminalActionsResponse.cs` |
| `PostTerminalsScheduleActionsError` | `src/Adyen/Errors/PostTerminalsScheduleActionsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

