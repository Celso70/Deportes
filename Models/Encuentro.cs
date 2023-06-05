using System.ComponentModel.DataAnnotations;

namespace Deportes.Models;

public class Encuentro
{
    [Key]
    public int EncuentroID { get; set; }
    public DateTime Duracion { get; set; }
    //PRECIO
    // public string? Precio { get; set; }
    public bool Resultado { get; set; }
    //LUGAR
    //DEPORTE
    //EQUIPOS

    // ICollection<SubCategoria>?SubCategorias { get; set; }
}