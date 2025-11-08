using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestionDeContactos.Models
{
    [Index(nameof(email), IsUnique = true)]
    class Contacto
    {
        [Key]
        public int idContacto { get; set; }
        [Required]
        [MaxLength(100)]
        public string nombre { get; set; }
        [MaxLength(20)]
        public string? telefono { get; set; }
        [MaxLength(150)]
        public string? email { get; set; }


    }
}
