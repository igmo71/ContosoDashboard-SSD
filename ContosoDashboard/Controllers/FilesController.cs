using Microsoft.AspNetCore.Mvc;
using ContosoDashboard.Services;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ContosoDashboard.Data;

namespace ContosoDashboard.Controllers;

[ApiController]
[Route("api/files")]
public class FilesController : ControllerBase
{
    private readonly IDocumentService _documentService;
    private readonly IFileStorageService _storage;

    public FilesController(IDocumentService documentService, IFileStorageService storage)
    {
        _documentService = documentService;
        _storage = storage;
    }

    [HttpPost("upload")]
    [Authorize]
    public async Task<IActionResult> Upload([FromForm] IFormFile file, [FromForm] string title, [FromForm] string? description, [FromForm] string category = "General", [FromForm] int? projectId = null, [FromForm] string? tags = null)
    {
        if (file == null || file.Length == 0) return BadRequest("File is required");

        var idClaim = User.FindFirst(ClaimTypes.NameIdentifier);
        if (idClaim == null) return Unauthorized();
        if (!int.TryParse(idClaim.Value, out var userId)) return Unauthorized();

        var doc = await _documentService.UploadAsync(file, title ?? file.FileName, description, category, userId, projectId, tags);

        return Ok(new { doc.DocumentId, doc.Title, doc.FilePath });
    }

    [HttpGet("{id:int}")]
    [Authorize]
    public async Task<IActionResult> Get(int id)
    {
        var doc = await _documentService.GetAsync(id);
        if (doc == null) return NotFound();

        var full = _storage.GetFullPath(doc.FilePath);
        if (!System.IO.File.Exists(full)) return NotFound();

        var stream = System.IO.File.OpenRead(full);
        return File(stream, doc.ContentType ?? "application/octet-stream", doc.Title + Path.GetExtension(doc.FilePath));
    }
}
