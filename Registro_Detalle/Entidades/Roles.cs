using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Registro_Detalle.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public bool esActivo { get; set; }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }

        public Roles() {
            RolId = 0;
            FechaCreacion = DateTime.Now;
            Descripcion = string.Empty;
            esActivo = false;

            RolesDetalle = new List<RolesDetalle>();
        }
    }
}
