using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Provee_De_Materi_Obra
    {
        public string Recibo { set; get; }
        public string Entrega { set; get; }
        public int Cantidad { set; get; }
        public string Fecha_Entre { set; get; }
        public float Precio { set; get; }
        public int ID_Obra { set; get; }
        public int ID_Material { set; get; }
        public int ID_Proveedor { set; get; }

    }
}
