#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace TicketsTracker.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; } 
    [Required]
    [MinLength(2,ErrorMessage="Product name must be 2 characters or longer!")]
    public string ProductName { get; set; }

    public string ProductDescription { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}