using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Obra
    {
        public string Nom_Obra { set; get; }
        public string Direccion { set; get; }
        public  string Fecha_Inicio { set; get; }
        public  string Fecha_Termino { set; get; }
        public int ID_Dueno { set; get; }
        public int ID_Encargado { set; get; }
    }
}
