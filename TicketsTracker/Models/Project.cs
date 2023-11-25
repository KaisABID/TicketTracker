#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TicketsTracker.Models;

public class Project
{
    [Key]
    public int ProjectId { get; set; } 
    [Required]
    [MinLength(2,ErrorMessage="Project name must be 2 characters or longer!")]
    public string ProjectName { get; set; }

    [Required]
    public String ClientName { get; set; }

    public String ProjectDescription { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}