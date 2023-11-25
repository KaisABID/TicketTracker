#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TicketsTracker.Models;

public class Ticket
{
    [Key]
    public int TicketId { get; set; } 
    [Required]
    [MinLength(2,ErrorMessage="Product name must be 2 characters or longer!")]
    public string TickResume { get; set; }
    [Required]
    public DateTime TickDate { get; set; }

    [Required]
    public string TickClient { get; set; }
    public string TickContact { get; set; }
    public string TickProduct { get; set; }
    public string TickProject { get; set; }

    public string TickDescription { get; set; }

    public int TickAssignedTo { get; set; }
    
    public DateOnly Tickdeadline { get; set; }

    public string TickType { get; set; }
    public string TickPriority { get; set; }
    public string TickStatus { get; set; }
    public int TickTime { get; set; }

    public string TickRanking { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; } 

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}