# Tasks: Document Upload and Management

Phase 1: Setup

- [ ] T001 Create configuration entry `DocumentStorageRoot` in ContosoDashboard/appsettings.json
- [ ] T002 [P] Create quickstart doc update in specs/001-document-upload-and-management/quickstart.md to include storage example and reset steps
- [ ] T003 Add migration notes file specs/001-document-upload-and-management/migrations-notes.md describing EF Core migration and SQLite usage

Phase 2: Foundational

- [ ] T004 Implement `Document` entity in ContosoDashboard/Data/Document.cs
- [ ] T005 Implement `DocumentShare` entity in ContosoDashboard/Data/DocumentShare.cs
- [ ] T006 Implement `DocumentActivity` entity in ContosoDashboard/Data/DocumentActivity.cs
- [ ] T007 [P] Update ContosoDashboard/Data/ApplicationDbContext.cs to register new entities and add DbSet properties
- [ ] T008 Create `Services/IFileStorageService.cs` interface in ContosoDashboard/Services/IFileStorageService.cs
- [ ] T009 Implement `LocalFileStorageService` in ContosoDashboard/Services/LocalFileStorageService.cs to store files outside wwwroot using configured `DocumentStorageRoot`
- [ ] T010 Implement `Services/DocumentService.cs` in ContosoDashboard/Services/DocumentService.cs with upload, validate, metadata persistence, and activity logging (no scanning)
- [ ] T011 Create EF Core migration scaffold notes file specs/001-document-upload-and-management/tasks-migration-steps.md with commands to add & apply migration
- [ ] T012 [P] Add unit tests project or tests folder specs/001-document-upload-and-management/tests/ for DocumentService basic unit tests

Phase 3: User Stories

Phase 3.1: [US1] Upload and manage personal and project documents (Priority: P1)

- [ ] T013 [US1] Create upload page ContosoDashboard/Pages/Documents.razor with `InputFile` based multi-file upload UI (title, category, project select, tags, description)
- [ ] T014 [US1] Create document details page ContosoDashboard/Pages/DocumentDetails.razor to view metadata, preview, edit metadata, replace file, and delete
- [ ] T015 [US1] Implement API endpoint ContosoDashboard/Controllers/FilesController.cs POST /api/files/upload following contract to accept multipart/form-data and call DocumentService
- [ ] T016 [US1] Implement server-side validation in DocumentService: allowed types, max 25MB, required title and category; return clear errors to controller
- [ ] T017 [US1] Persist uploaded file metadata from upload flow into database and write file via IFileStorageService (ContosoDashboard/Services/DocumentService.cs)
- [ ] T018 [US1] Implement owner-only edit/delete authorization checks in ContosoDashboard/Controllers/FilesController.cs and DocumentService
- [ ] T019 [US1] Add client-side feedback and success/error messages on ContosoDashboard/Pages/Documents.razor and ContosoDashboard/Pages/DocumentDetails.razor
- [ ] T020 [US1] [P] Add integration test specs/001-document-upload-and-management/tests/us1_upload_flow.cs verifying upload, metadata persistence, and download availability
- [ ] T021 [US1] Add audit logging in DocumentService to record upload actions in ContosoDashboard/Data/DocumentActivity table
- [ ] T022 [US1] [P] Add UI route link in ContosoDashboard/Shared/NavMenu.razor to Documents page

Phase 3.2: [US2] Browse, search, and access shared and project documents (Priority: P2)

- [ ] T023 [US2] Implement secure download and preview endpoints in ContosoDashboard/Controllers/FilesController.cs GET /api/files/{documentId} and GET /api/files/{documentId}/preview following contract
- [ ] T024 [US2] Implement server-side search in ContosoDashboard/Services/DocumentService.cs supporting title, description, tags, uploader, project filters and sorting
- [ ] T025 [US2] Create Documents list view enhancements ContosoDashboard/Pages/Documents.razor to include filters, search box, sorting, and pagination
- [ ] T026 [US2] Implement sharing UI in ContosoDashboard/Pages/DocumentDetails.razor to share with user or team and persist DocumentShare entity
- [ ] T027 [US2] Implement Shared With Me view ContosoDashboard/Pages/SharedWithMe.razor showing documents shared to current user
- [ ] T028 [US2] Implement notification trigger in DocumentService to create in-app notification when a document is shared (ContosoDashboard/Services/NotificationService.cs usage)
- [ ] T029 [US2] [P] Add integration tests specs/001-document-upload-and-management/tests/us2_search_share.cs verifying search returns only authorized results and sharing flows
- [ ] T030 [US2] Ensure download/preview endpoints enforce authorization and log activity to DocumentActivity

Phase 3.3: [US3] Integrate documents with tasks and dashboard insights (Priority: P3)

- [ ] T031 [US3] Add document attachment capability in ContosoDashboard/Pages/ProjectDetails.razor and ContosoDashboard/Pages/Tasks.razor to link existing documents to tasks (UI change files)
- [ ] T032 [US3] Update data model relation and service method ContosoDashboard/Services/DocumentService.cs to link documents to TaskItem and Project where applicable
- [ ] T033 [US3] Add dashboard widget ContosoDashboard/Shared/RecentDocuments.razor showing last 5 uploads and a document count summary on MainLayout or Index.razor
- [ ] T034 [US3] [P] Add integration test specs/001-document-upload-and-management/tests/us3_integration.cs verifying attach-to-task and dashboard visibility
- [ ] T035 [US3] Add notification when a document is attached to a task to notify project members (hook into NotificationService)

Final Phase: Polish & Cross-Cutting Concerns

- [ ] T036 Improve error handling and user-facing messages across upload, download, preview, and edit flows (files under ContosoDashboard/Pages and Controllers)
- [ ] T037 [P] Add server-side unit/integration tests for audit logging and authorization (expand specs/001-document-upload-and-management/tests/)
- [ ] T038 [P] Add configuration validation on startup in ContosoDashboard/Program.cs to ensure `DocumentStorageRoot` exists and is writable (fail with clear message)
- [ ] T039 Create docs/specs/001-document-upload-and-management/ops-notes.md describing production migration steps (virus scanning, cloud storage adapter, backup)
- [ ] T040 [P] Update README or StakeholderDocs/document-upload-and-management-feature.md with how to run locally and known limitations

---

Total tasks: 40

Summary:

- Total task count: 40
- Tasks per user story: US1=11 (T013-T022), US2=8 (T023-T030), US3=5 (T031-T035)
- Parallel opportunities identified: T002, T007, T012, T020, T022, T029, T034, T037, T038, T040 (marked with [P])
- Suggested MVP scope: Implement Phase 1, Phase 2 foundational tasks, and Phase 3.1 (User Story 1) — tasks T001 through T022
