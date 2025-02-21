using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Mission6_Whitworth.Models;

public class Movie
{
    
    [Key]
    public int movieId { get; set; }
    [Required]
    public string  Title { get; set; }  
    public string? Rating { get; set; }
    
    [ForeignKey("CategoryID")]
    public int? CategoryId { get; set; }
    public Category? CategoryName { get; set; }
    
    [Required]
    public int Year { get; set; }
    public string? Director { get; set; }
    [Required]
    public bool Edited { get; set; } = false;
    public string? LentTo { get; set; }
    [Required]
    public bool CopiedToPlex { get; set; } = false;
    public string? Notes { get; set; }
    
}