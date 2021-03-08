using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Detalle.BLL
{
    class Utilitarios
    {
        public static int ToInt(string valor)
        {
            int retorno = 0;
            int.TryParse(valor, out retorno);
            return retorno;
        }
    }
}
