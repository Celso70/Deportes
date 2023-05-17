using System.ComponentModel.DataAnnotations;

namespace Deportes.Models;

public class Torneo
{
    [Key]
    public int TorneoID { get; set; }
    //PRECIO
    // public string? Precio { get; set; }
    public DateTime Calendario { get; set; }
    public string? Premios { get; set; }
    public bool Resultado { get; set; }
    //DEPORTE
    //EQUIPOS
    //LUGAR

    // ICollection<SubCategoria>?SubCategorias { get; set; }
}