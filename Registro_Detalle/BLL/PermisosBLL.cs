using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Detalle.Entidades;
using Registro_Detalle.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Registro_Detalle.BLL
{
    class PermisosBLL
    {
        private static bool Insertar(Permisos permiso)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Permisos.Add(permiso);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Permisos permiso)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(permiso).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Permisos.Any(e => e.PermisoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool ExisteDescripcion(string descripcion, int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Permisos.Any(e => e.Descripcion == descripcion);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            if (encontrado)
            {
                Permisos permiso = Buscar(id);

                if (permiso == null)
                    return true;

                if (permiso.Descripcion == descripcion)
                    encontrado = false;
            }

            return encontrado;
        }

        public static bool Guardar(Permisos permiso)
        {

            if (!Existe(permiso.PermisoId))
                return Insertar(permiso);
            else
                return Modificar(permiso);

        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var permiso = contexto.Permisos.Find(id);

                if (permiso != null)
                {
                    contexto.Permisos.Remove(permiso);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static List<Permisos> GetList(Expression<Func<Permisos, bool>> criterio)
        {
            List<Permisos> Lista = new List<Permisos>();
            Contexto contexto = new Contexto();

            try
            {

                Lista = contexto.Permisos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
        public static List<Permisos> GetRoles()
        {
            List<Permisos> lista = new List<Permisos>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Permisos.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }


        public static Permisos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Permisos permiso;

            try
            {
                permiso = contexto.Permisos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return permiso;
        }

    }
}
