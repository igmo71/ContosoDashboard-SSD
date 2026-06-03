using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace ContosoDashboard.Services;

public class LocalFileStorageService : IFileStorageService
{
    private readonly string _root;

    public LocalFileStorageService(IConfiguration configuration)
    {
        var configured = configuration["DocumentStorageRoot"]; 
        _root = string.IsNullOrWhiteSpace(configured) ? "Data/Documents" : configured!;

        // ensure root is absolute-ish
        if (!Path.IsPathRooted(_root))
        {
            var basePath = AppContext.BaseDirectory;
            _root = Path.GetFullPath(Path.Combine(basePath, _root));
        }

        if (!Directory.Exists(_root))
        {
            Directory.CreateDirectory(_root);
        }
    }

    public async Task<string> SaveFileAsync(IFormFile file, string? folder = null)
    {
        var folderPath = string.IsNullOrWhiteSpace(folder) ? "documents" : folder.Trim();
        var destFolder = Path.Combine(_root, folderPath);
        if (!Directory.Exists(destFolder)) Directory.CreateDirectory(destFolder);

        var fileExt = Path.GetExtension(file.FileName);
        var fileName = Guid.NewGuid().ToString("N") + fileExt;
        var relativePath = Path.Combine(folderPath, fileName).Replace("\\", "/");
        var fullPath = Path.Combine(_root, relativePath);

        using (var stream = new FileStream(fullPath, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }

        return relativePath;
    }

    public string GetFullPath(string relativePath)
    {
        var rel = relativePath.Replace("/", Path.DirectorySeparatorChar.ToString());
        return Path.Combine(_root, rel);
    }
}
