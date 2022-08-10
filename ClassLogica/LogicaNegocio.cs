using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassAcceso;
using ClassLibrary1;

namespace ClassLogica
{
    public class LogicaNegocio
    {
        public AccesoSQl nuevo = null;

        public LogicaNegocio(string conec)
        {
            nuevo = new AccesoSQl(conec);
        }

        public List<Dueno> VerDueno(ref string m)
        {
            List<Dueno> lista = new List<Dueno>();

            SqlDataReader atrapa = null;

            SqlConnection nuev = null;
            nuev = nuevo.AbrirConexion(ref m);

            string consulta = "Select Nombre_Dueno from Dueno";

            atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new Dueno()
                    {

                        Nombre_Dueno = (string)atrapa[0]
                    }
                    );
                }
            }
            nuev.Close();
            nuev.Dispose();
            return lista;
        }

        public List<EncargadoObra> VerEncargado(ref string m)
        {
            List<EncargadoObra> lista = new List<EncargadoObra>();

            SqlDataReader atrapa = null;

            SqlConnection nuev = null;
            nuev = nuevo.AbrirConexion(ref m);

            string consulta = "Select Nombre_Encargado from EncargadoObra";

            atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new EncargadoObra()
                    {

                        Nombre_Encargado = (string)atrapa[0]
                    }
                    );
                }
            }
            nuev.Close();
            nuev.Dispose();
            return lista;
        }

        public List<Proveedor> VerProv(ref string m)
        {
            List<Proveedor> lista = new List<Proveedor>();

            SqlDataReader atrapa = null;

            SqlConnection nuev = null;
            nuev = nuevo.AbrirConexion(ref m);

            string consulta = "Select Razon from Proveedor";

            atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new Proveedor()
                    {

                        Razon = (string)atrapa[0]
                    }
                    );
                }
            }
            nuev.Close();
            nuev.Dispose();
            return lista;
        }

        public List<TipoMaterial> VerTipo(ref string m)
        {
            List<TipoMaterial> lista = new List<TipoMaterial>();

            SqlDataReader atrapa = null;

            SqlConnection nuev = null;
            nuev = nuevo.AbrirConexion(ref m);

            string consulta = "Select Tipo from Material";

            atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new TipoMaterial()
                    {

                        Tipo = (string)atrapa[0],
                      
                    }
                    );
                }
            }
            nuev.Close();
            nuev.Dispose();
            return lista;
        }

        public List<Obra> VerObra(ref string m)
        {
            List<Obra> lista = new List<Obra>();

            SqlDataReader atrapa = null;

            SqlConnection nuev = null;
            nuev = nuevo.AbrirConexion(ref m);

            string consulta = "Select Nom_Obra from Obra";

            atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new Obra()
                    {

                        Nom_Obra = (string)atrapa[0],

                    }
                    );
                }
            }
            nuev.Close();
            nuev.Dispose();
            return lista;
        }

        public List<Material> VerMaterial(ref string m)
        {
            List<Material> lista = new List<Material>();

            SqlDataReader atrapa = null;

            SqlConnection nuev = null;
            nuev = nuevo.AbrirConexion(ref m);

            string consulta = "Select Descripcion_Mat from Material";

            atrapa = nuevo.Consulta_DataReader(consulta, nuev, ref m);

            if (atrapa != null)
            {
                while (atrapa.Read())
                {
                    lista.Add(new Material()
                    {

                        Descripcion_Mat = (string)atrapa[0],

                    }
                    );
                }
            }
            nuev.Close();
            nuev.Dispose();
            return lista;
        }

        public DataTable VerDuenos(ref string m)
        {
            string Ver = "";
            DataSet guarda = null;
            DataTable resultado = null;
            guarda = nuevo.Consulta_DataSet_Simple(Ver, nuevo.AbrirConexion(ref m), ref m);
            if (guarda != null)
            {
                resultado = guarda.Tables[0];

            }
            return resultado;
        }
        public Boolean InsertaObra(Obra nueva, ref string m)
        {
            string Insertar = "insert into Obra(Nom_obra, Direccion, Fecha_Inicio, Fecha_Termino, ID_Dueno, ID_Encargado)" +
                " values (@nom, @dir, @fechi, @fecht, @iddueno, @idencargado )";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("nom", SqlDbType.VarChar,40),
                new SqlParameter("dir", SqlDbType.VarChar,60),
                new SqlParameter("fechi",SqlDbType.Date),
                new SqlParameter("fecht", SqlDbType.Date),
                new SqlParameter("iddueno", SqlDbType.Int),
                new SqlParameter("idencargado", SqlDbType.Int)

            };

            coleccion[0].Value = nueva.Nom_Obra;
            coleccion[1].Value = nueva.Direccion;
            coleccion[2].Value = nueva.Fecha_Inicio;
            coleccion[3].Value = nueva.Fecha_Termino;
            coleccion[4].Value = nueva.ID_Dueno;
            coleccion[5].Value = nueva.ID_Encargado;

            Boolean salida = false;

            salida = nuevo.InsertarBD(Insertar, nuevo.AbrirConexion(ref m), ref m, coleccion);

            return salida;
        }

        public Boolean InsertaMaterial(Material nueva, ref string m)
        {
            string Insertar = "insert into Material(Descripcion_Mat, Marca, Presentacion, ID_Tipo)" +
                " values (@des, @marca, @presen, @id_tip)";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("des", SqlDbType.VarChar,60),
                new SqlParameter("marca", SqlDbType.VarChar,40),
                new SqlParameter("presen",SqlDbType.VarChar,60),
                new SqlParameter("idencargado", SqlDbType.Int)

            };

            coleccion[0].Value = nueva.Descripcion_Mat;
            coleccion[1].Value = nueva.Marca;
            coleccion[2].Value = nueva.Presentacion;
            coleccion[3].Value = nueva.ID_Tipo;

            Boolean salida = false;

            salida = nuevo.InsertarBD(Insertar, nuevo.AbrirConexion(ref m), ref m, coleccion);

            return salida;
        }

        public Boolean InsertaProve_Mat(Provee_De_Materi_Obra nueva, ref string m)
        {
            string Insertar = "insert into Provee_De_Materi_Obra(Recibo, Entrega, Cantidad, Fecha_Entre, Precio, ID_Obra, ID_Material, ID_Proveedor)" +
                " values (@rec, @entre, @can, @fechen, @id_obra, @id_pro, @idencargado )";
            SqlParameter[] coleccion = new SqlParameter[]
            {

                new SqlParameter("rec", SqlDbType.VarChar,30),
                new SqlParameter("entre", SqlDbType.VarChar,30),
                new SqlParameter("can",SqlDbType.Float),
                new SqlParameter("fechen", SqlDbType.Date),
                new SqlParameter("id_obra", SqlDbType.Int),
                new SqlParameter("id_pro", SqlDbType.Int),
                new SqlParameter("idencargado", SqlDbType.Int)

            };

            coleccion[0].Value = nueva.Recibo;
            coleccion[1].Value = nueva.Entrega;
            coleccion[2].Value = nueva.Cantidad;
            coleccion[3].Value = nueva.Fecha_Entre;
            coleccion[4].Value = nueva.ID_Obra;
            coleccion[5].Value = nueva.ID_Material;
            coleccion[6].Value = nueva.ID_Proveedor;

            Boolean salida = false;

            salida = nuevo.InsertarBD(Insertar, nuevo.AbrirConexion(ref m), ref m, coleccion);

            return salida;
        }
    }
}

