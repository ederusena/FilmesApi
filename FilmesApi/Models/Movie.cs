using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Movie
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo do filme é obrigatorio.")]
    public string? Title { get; set; }
    [Required(ErrorMessage = "O genero do filme é obrigatorio.")]
    [MaxLength(50, ErrorMessage = "Maximo de 50 caracteres para Genero.")]
    public string? Genre { get; set; }
    [Required(ErrorMessage = "O duraçãoW do filme é obrigatorio.")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duration { get; set; }
    
}
