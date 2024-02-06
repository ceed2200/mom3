using System.ComponentModel.DataAnnotations;

namespace MOM3.Models;

public class BookModel {

    // Properties
    public int Id { get; set; }    
    
    [Required]
    [Display(Name = "Namn")]
    public string?  BookName { get; set; }

    // Denna skapades av misstag, behövs ej
    public string?  BookGenre { get; set; }

     [Required]
    public int? GenreModelId { get; set; }    

    public GenreModel? Genre { get; set; }   
}