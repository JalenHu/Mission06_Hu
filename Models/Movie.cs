using System.ComponentModel.DataAnnotations;
namespace Mission06_Hu.Models;

public class Movie
{
    [Key]
    public int MovieId { get; set; }
    [Required(ErrorMessage = "The field is required")]
    public string Category { get; set; }
    [Required (ErrorMessage = "The field is required")]
    public string Title { get; set; }
    [Required (ErrorMessage = "The field is required.")]
    [Range (1888, 2100, ErrorMessage = "Enter a valid movie year")]
    public int Year { get; set; }
    [Required  (ErrorMessage = "The field is required")]
    public string Director { get; set; }
    [Required  (ErrorMessage = "The field is required")]
    public string Rating { get; set; }
    
    
    public bool Edited { get; set; }
    
    public string? LentTo { get; set; }
    
    [StringLength(25)]
    public string? Note { get; set; }
   
}