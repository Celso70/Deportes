using System.ComponentModel.DataAnnotations;

namespace Deportes.Models;

public class Equipo
{
    [Key]
    public int EquipoID { get; set; }
    public string? Descripcion { get; set; }
    //campo que muestre integrantes
    //relacion con deporteid y descripcion


    // ICollection<SubCategoria>?SubCategorias { get; set; }
}