# Data Model: Document Upload and Management

## Entities

### Document
- `DocumentId` (int, PK)
- `Title` (string, required)
- `Description` (string, optional)
- `Category` (string, required)
- `Tags` (string or related table, optional)
- `ProjectId` (int?, FK to `Project`, nullable)
- `UploaderUserId` (int, FK to `User`)
- `UploadDate` (DateTime)
- `FileSize` (long)
- `ContentType` (string, varchar(255))
- `FilePath` (string, storage path relative to configured root)
- `IsActive` (bool)

### DocumentShare
- `DocumentShareId` (int, PK)
- `DocumentId` (int, FK)
- `SharedWithUserId` (int, FK to `User`, nullable)
- `SharedWithTeam` (string, nullable)
- `GrantedByUserId` (int, FK)
- `GrantedDate` (DateTime)

### DocumentTag (option)
- `DocumentTagId` (int, PK)
- `DocumentId` (int, FK)
- `Tag` (string)

### DocumentActivity
- `DocumentActivityId` (int, PK)
- `DocumentId` (int, FK)
- `Action` (string: Upload, Download, Delete, Share, Edit)
- `PerformedByUserId` (int, FK)
- `PerformedAt` (DateTime)
- `Details` (string, optional)

## Indexes and Constraints
- Unique index on `DocumentId` (PK)
- Index on `ProjectId` and `UploaderUserId` for query performance
- `ContentType` length 255 to accommodate long MIME strings

## Notes
- `FilePath` stores a relative path; the `LocalFileStorageService` resolves the full path.
- Category is text to simplify management and support admin-editable categories.
