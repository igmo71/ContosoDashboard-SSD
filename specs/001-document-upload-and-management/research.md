# Research: Document Upload and Management

## Decisions

- Storage: Local filesystem outside `wwwroot` for training; path pattern `{userId}/{projectId|personal}/{guid}.{ext}`.
- Database: Use EF Core with SQLite for metadata (consistent with earlier repo switch to SQLite).
- Malware scanning: Deferred to production; training will not implement scanning but will include notes and hooks for adding it in production.
- DocumentId: Integer primary key to match existing entity keys and simplify joins.
- File access: Serve files via authenticated controller endpoints to enforce authorization checks.

## Rationale

- Local filesystem keeps training simple and offline-capable while allowing clear migration to Azure Blob Storage via an `IFileStorageService` abstraction.
- SQLite is lightweight and consistent with the project's training focus.
- Deferring malware scanning reduces operational complexity for training and prevents false positives during exercises; production plan will include scanning integration.

## Alternatives considered

- Use GUID primary keys: rejected to maintain consistency with existing integer keys.
- Use LocalDB/SQL Server: rejected in favor of SQLite for portability.

