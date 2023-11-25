#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TicketsTracker.Models;

public class Comment
{
    [Key]
    public int CommentId { get; set; } 
    [Required]
    public int TicketId { get; set; }
    [Required]
    public string TickComment { get; set; }

    public int UserId { get; set; }

    public User? User { get; set; } 

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}