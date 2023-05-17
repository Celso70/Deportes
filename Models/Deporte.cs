using System.ComponentModel.DataAnnotations;

namespace Deportes.Models;

public class Deporte
{
    [Key]
    public int DeporteID { get; set; }
    public string? Descripcion { get; set; }
    public string? Reglas { get; set; }

    // ICollection<SubCategoria>?SubCategorias { get; set; }
}