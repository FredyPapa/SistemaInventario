using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es Requerido")]
        [MaxLength(60, ErrorMessage = "El nombre debe tener como máximo 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripción es Requerido")]
        [MaxLength(100, ErrorMessage = "La descripción debe tener como máximo 100 caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Estado es Requerido")]
        public bool Estado { get; set; }
    }
}
