EF Core migration steps for Document Upload feature (run locally)

1. Ensure `dotnet-ef` is available:

```powershell
dotnet tool install --global dotnet-ef --version 8.0.0
```

2. From the `ContosoDashboard` project folder, add a migration:

```powershell
cd ContosoDashboard
dotnet ef migrations add AddDocumentsFeature --project . --startup-project .
```

3. Apply the migration to the SQLite database:

```powershell
dotnet ef database update --project . --startup-project .
```

Notes: this project currently uses `EnsureCreated()` in `Program.cs` for development. To use migrations instead, consider replacing `EnsureCreated()` with `context.Database.Migrate()`.
