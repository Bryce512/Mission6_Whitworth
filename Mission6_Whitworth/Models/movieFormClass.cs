using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mission6_Whitworth.Models;

public class movieFormClass
{
    
    [Key]
    public int movieId { get; set; }
    [Required]
    public string  Title { get; set; }  
    [Required]
    public string Rating { get; set; }
    public string Category { get; set; }
    public int Year { get; set; }
    public string Director { get; set; }
    public string Edit { get; set; }
    public string? Lent { get; set; }
    public string? Notes { get; set; }
    
}