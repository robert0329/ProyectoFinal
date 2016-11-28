using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class Utilidades
    {
        public static int ToInt(string Numero)
        {
            int retorno = 0;

            int.TryParse(Numero, out retorno);

            return retorno;
        }
        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }
    }
}
