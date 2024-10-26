using System.ComponentModel.DataAnnotations;

namespace apiEmpresa.Models;
public class Clientes{
    [Key]
    public Int32 id_cliente { get; set; }
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono  { get; set; }
    public DateTime? Fecha_nacimiento  { get; set; }
}