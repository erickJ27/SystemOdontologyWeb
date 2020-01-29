using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombres { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 2, ErrorMessage = "Nivel de usuario invalido")]
        public int NivelUsuario { get; set; }
        [Required(ErrorMessage = "El usuario es requerido")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "La clave es requerida")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }


    }
}
