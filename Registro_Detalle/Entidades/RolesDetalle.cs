using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Registro_Detalle.Entidades
{
    public class RolesDetalle
    {
        [Key]
        public int Id { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public bool esAsignado { get; set; }

        public RolesDetalle()
        {
            Id = 0;
            RolId = 0;
            PermisoId = 0;
            esAsignado = false;
        }

        public RolesDetalle(int Id, int RolId, int PermisoId, bool esAsignado)
        {
            this.Id = Id;
            this.RolId = RolId;
            this.PermisoId = PermisoId;
            this.esAsignado = esAsignado;
        }

        /* public RolesDetalle(int id, int rolid, int permisoid, bool esasignado)
         {
             Id = id;
             RolId = rolid;
             PermisoId = permisoid;
             esAsignado = esasignado;
         }*/
    }
}
