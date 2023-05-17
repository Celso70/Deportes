using System.ComponentModel.DataAnnotations;

namespace Deportes.Models;

public class Encargado
{
    [Key]
    public int EncargadoID { get; set; }
    public string? Nombre { get; set; }
    //LUGAR
    public DateTime? Horarios { get; set; }


    // ICollection<SubCategoria>?SubCategorias { get; set; }
}