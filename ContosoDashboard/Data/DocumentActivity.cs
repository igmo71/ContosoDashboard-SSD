using System.ComponentModel.DataAnnotations;

namespace ContosoDashboard.Data;

public class DocumentActivity
{
    [Key]
    public int DocumentActivityId { get; set; }

    public int DocumentId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Action { get; set; } = string.Empty; // Upload, Download, Delete, Share, Edit

    public int PerformedByUserId { get; set; }

    public DateTime PerformedAt { get; set; } = DateTime.UtcNow;

    public string? Details { get; set; }
}
