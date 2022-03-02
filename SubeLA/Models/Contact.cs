using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SubeLA.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayName("Nombre")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Mensaje")]
        [DataType(DataType.MultilineText)]
        public string Messagge { get; set; }
    }
}
