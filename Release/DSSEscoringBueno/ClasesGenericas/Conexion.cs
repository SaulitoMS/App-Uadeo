using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DSSEscoringBueno.ClasesGenericas
{
    internal class Conexion
    {
        public string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
    
}
