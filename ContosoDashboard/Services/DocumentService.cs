using ContosoDashboard.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ContosoDashboard.Services;

public class DocumentService : IDocumentService
{
    private readonly ApplicationDbContext _db;
    private readonly IFileStorageService _storage;

    public DocumentService(ApplicationDbContext db, IFileStorageService storage)
    {
        _db = db;
        _storage = storage;
    }

    public async Task<Document> UploadAsync(IFormFile file, string title, string? description, string category, int uploaderUserId, int? projectId = null, string? tags = null)
    {
        // save file
        var relativePath = await _storage.SaveFileAsync(file);

        var doc = new Document
        {
            Title = title,
            Description = description,
            Category = category,
            Tags = tags,
            ProjectId = projectId,
            UploaderUserId = uploaderUserId,
            UploadDate = DateTime.UtcNow,
            FileSize = file.Length,
            ContentType = file.ContentType,
            FilePath = relativePath,
            IsActive = true
        };

        _db.Documents.Add(doc);
        await _db.SaveChangesAsync();

        // activity
        var activity = new DocumentActivity
        {
            DocumentId = doc.DocumentId,
            Action = "Upload",
            PerformedByUserId = uploaderUserId,
            PerformedAt = DateTime.UtcNow,
            Details = $"Uploaded file {file.FileName}"
        };
        _db.DocumentActivities.Add(activity);
        await _db.SaveChangesAsync();

        return doc;
    }

    public async Task<Document?> GetAsync(int id)
    {
        return await _db.Documents.FirstOrDefaultAsync(d => d.DocumentId == id && d.IsActive);
    }

    public async Task<IEnumerable<Document>> SearchAsync(string? q = null, int? projectId = null, int? uploaderUserId = null)
    {
        var query = _db.Documents.AsQueryable();
        if (!string.IsNullOrWhiteSpace(q))
        {
            query = query.Where(d => d.Title.Contains(q) || (d.Description != null && d.Description.Contains(q)) || (d.Tags != null && d.Tags.Contains(q)));
        }
        if (projectId.HasValue) query = query.Where(d => d.ProjectId == projectId.Value);
        if (uploaderUserId.HasValue) query = query.Where(d => d.UploaderUserId == uploaderUserId.Value);

        return await query.OrderByDescending(d => d.UploadDate).ToListAsync();
    }
}
