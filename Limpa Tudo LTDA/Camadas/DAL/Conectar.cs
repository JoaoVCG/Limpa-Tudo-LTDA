using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.DAL
{
    public class Conectar
    {
        public static string getConectar()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=limpatudoltda;Integrated Security=True";
        }
    }
}
