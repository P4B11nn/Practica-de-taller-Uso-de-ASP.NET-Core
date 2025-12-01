using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller_ASP.NET_Core.Models
{
    public class TaskItem
    {
        // El orden si importa, las restricciones deben colocarse antes de declarar las propiedades.


        // Llave primaria
        public int id { get; set; }

        // Título de la tarea
        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(200, ErrorMessage = "El título no puede exceder 200 caracteres")]
        public string Title { get; set; } = string.Empty;

        // Descripción de la tarea
        [StringLength(1000, ErrorMessage = "La descripción no puede exceder 1000 caracteres")]
        public string? Description { get; set; }

        // Estado de completado
        public bool IsCompleted { get; set; } = false;

        // Orden para drag & drop
        public int Order { get; set; } = 0;

        // Propiedades para imagen
        public byte[]? Image { get; set; }
        public string? ImageContentType { get; set; }

        // Propiedad para subir imagen (no se mapea a la BD)
        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        // Auditoría
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Foreign Key a AspNetUsers
        [BindNever]
        public string UserId { get; set; } = string.Empty;
    }
}