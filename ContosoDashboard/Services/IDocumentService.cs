using Microsoft.AspNetCore.Http;
using ContosoDashboard.Data;

namespace ContosoDashboard.Services;

public interface IDocumentService
{
    Task<Document> UploadAsync(IFormFile file, string title, string? description, string category, int uploaderUserId, int? projectId = null, string? tags = null);
    Task<Document?> GetAsync(int id);
    Task<IEnumerable<Document>> SearchAsync(string? q = null, int? projectId = null, int? uploaderUserId = null);
}
