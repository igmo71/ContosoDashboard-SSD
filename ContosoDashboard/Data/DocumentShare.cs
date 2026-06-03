using System.ComponentModel.DataAnnotations;

namespace ContosoDashboard.Data;

public class DocumentShare
{
    [Key]
    public int DocumentShareId { get; set; }

    public int DocumentId { get; set; }

    public int? SharedWithUserId { get; set; }

    public string? SharedWithTeam { get; set; }

    public int GrantedByUserId { get; set; }

    public DateTime GrantedDate { get; set; } = DateTime.UtcNow;
}
