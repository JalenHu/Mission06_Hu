using System.ComponentModel.DataAnnotations;
namespace Mission06_Hu.Models;

public class Movie
{
    [Key]
    public int? MovieId { get; set; }
    
    public int? CategoryId  { get; set; }
    public Category? Category { get; set; }
    
    [Required (ErrorMessage = "The field is required")]
    public string Title { get; set; }
    
    [Required]
    [Range (1888, 2100, ErrorMessage = "Enter a valid movie year")]
    public int Year { get; set; }
    
    public string? Director { get; set; }
    
    public string? Rating { get; set; }
    
    [Required  (ErrorMessage = "The field is required")]
    public bool Edited { get; set; }
    
    public string? LentTo { get; set; }
    
    [Required  (ErrorMessage = "The field is required")]
    public bool CopiedToPlex { get; set; }
    
    [StringLength(25)]
    public string? Notes { get; set; }
   
}