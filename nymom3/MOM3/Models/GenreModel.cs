using System.ComponentModel.DataAnnotations;

namespace MOM3.Models;

public class GenreModel {

    // Properties
    public int GenreModelId { get; set; }    
    
    [Required]
    [Display(Name = "Genre")]
    public string?  GenreName { get; set; }

    public List<BookModel>? Books { get; set; }

}