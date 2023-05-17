using System.ComponentModel.DataAnnotations;

namespace Deportes.Models;

public class Lugar
{
    [Key]
    public int LugarID { get; set; }
    public string? Descripcion { get; set; }

    //MAPA
    public string? Direccion { get; set; }
    //MAPA
    public DateTime Horarios { get; set; }
    //PRECIO
    // public string? Precio { get; set; }
    //ENCARGADO


    // ICollection<SubCategoria>?SubCategorias { get; set; }
}