# Quickstart: Document Upload and Management (Local)

1. Ensure you are in the repository root and .NET 10 SDK is installed.

```powershell
cd ContosoDashboard
dotnet run
```

2. Configure storage path in `appsettings.json` (default training path):

```json
"DocumentStorageRoot": "C:\\Users\\<you>\\AppData\\ContosoDashboard\\uploads"
```

3. Create the storage directory if it does not exist and ensure the app has write permissions.

4. Start the app and sign in using the mock login at `/login`.

5. Navigate to `/documents` to upload and manage files. The database will be created automatically (SQLite). 

6. To reset the documents dataset, delete `ContosoDashboard.db` and restart the app.

