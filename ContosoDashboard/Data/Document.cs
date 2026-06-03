using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoDashboard.Data;

public class Document
{
    [Key]
    public int DocumentId { get; set; }

    [Required]
    [MaxLength(500)]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Required]
    [MaxLength(200)]
    public string Category { get; set; } = string.Empty;

    public string? Tags { get; set; }

    public int? ProjectId { get; set; }

    public int UploaderUserId { get; set; }

    public DateTime UploadDate { get; set; } = DateTime.UtcNow;

    public long FileSize { get; set; }

    [MaxLength(255)]
    public string? ContentType { get; set; }

    [Required]
    public string FilePath { get; set; } = string.Empty; // relative path

    public bool IsActive { get; set; } = true;
}
