using Microsoft.AspNetCore.Http;

namespace ContosoDashboard.Services;

public interface IFileStorageService
{
    /// <summary>
    /// Saves the file under the configured storage root and returns the relative path to the saved file.
    /// </summary>
    Task<string> SaveFileAsync(IFormFile file, string? folder = null);

    /// <summary>
    /// Resolves a relative path to an absolute path on disk.
    /// </summary>
    string GetFullPath(string relativePath);
}
