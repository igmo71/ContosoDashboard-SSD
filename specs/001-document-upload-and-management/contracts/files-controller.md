# Contracts: FilesController API

## GET /api/files/{documentId}
- Description: Downloads the file for `documentId` if the caller is authorized.
- Response: `200 OK` with file stream and correct `Content-Type`, or `404`/`403`.

## GET /api/files/{documentId}/preview
- Description: Returns inline-friendly content or a generated preview when supported.
- Response: `200 OK` with preview MIME or `415` if unsupported.

## POST /api/files/upload
- Description: Uploads a file and returns `Document` metadata.
- Request: Multipart/form-data with `file`, `title`, `description`, `projectId` (optional), `category`.
- Response: `201 Created` with `Document` JSON including `DocumentId`.

## Security
- All endpoints require authenticated requests.
- `GET /api/files/{id}` checks that the caller is the uploader, a member of the project, or a user with explicit share permission.

