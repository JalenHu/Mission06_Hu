using System.ComponentModel.DataAnnotations;
namespace Mission06_Hu.Models;

public class Movie
{
    [Key]
    public int MovieId { get; set; }
    [Required]
    public string Category { get; set; }
    [Required]
    public string Title { get; set; }
    
    [Required]
    [Range (1888, 2100, ErrorMessage = "Enter a valid movie year")]
    public int Year { get; set; }
    [Required]
    public string Director { get; set; }
    public string Rating { get; set; }
    public bool Edit { get; set; }
    public string Lentto { get; set; }
    [StringLength(25)]
    public string Note { get; set; }
}