using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Blazor.Shared
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public DateTime FechaAlta { get; set; } 
        public DateTime FechaBaja { get; set; } = DateTime.Now;

    }
}
