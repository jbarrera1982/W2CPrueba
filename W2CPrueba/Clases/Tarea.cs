using System.Security.Principal;
using W2CPrueba.Clases;

namespace W2CPrueba.Clases
{
    public class Tarea
    {
        public int Id { get; set; }
        public Usuario? IdUsuario { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime Finalizado { get; set; }
        public DateTime Eliminado { get; set; }
        public string? Tags { get; set; }        
        public DateTime CreatedAt { get; set; }
        public Prioridad? Prioridad { get; set; }
    }
}
