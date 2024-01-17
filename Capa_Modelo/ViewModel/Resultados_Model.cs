using Capa_Datos.Data.Resultados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.ViewModel
{
    public  class Resultados_Model
    {
        ResultadosData Resultados = new ResultadosData();

        private int id;
        private string nombre;
        private byte[] documento;
        private string extension;
        private int categoria;
        private decimal precio;
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Documento { get => documento; set => documento = value; }
        public string Extension { get => extension; set => extension = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public decimal Precio { get => precio; set => precio = value; }

        public void Insertar_Resultados(string Nombre, string NombrePaciente, byte[] Documento, string Extension, int Categoria, decimal Precio)
        {
            Resultados.InsertarResultados(Nombre, NombrePaciente, Documento, Extension, Categoria, Precio);
        }
        public Object LeerResultado()
        {
            return Resultados.Read();
        }
        public List<Resultados_Model> filtroDocumentos(int id)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-A7DCQGN;Initial Catalog=DBLaboratory;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                var tabla = ArchivoId(id);
                var infoDocumennto = new List<Resultados_Model>();

                foreach (DataRow item in tabla.Rows)
                {
                    infoDocumennto.Add(new Resultados_Model
                    {
                        Id = Convert.ToInt32(item[0]),
                        Nombre = item[1].ToString(),
                        Documento = (byte[])item[2],
                        Extension = item[3].ToString()
                    });
                }

                conexion.Close();

                return infoDocumennto;
            }
        }
        public DataTable ArchivoId(int Id)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-A7DCQGN;Initial Catalog=DBLaboratory;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                DataTable tabla = new DataTable();

                SqlCommand comando = new SqlCommand("select cod_examen,nombre,Convert(varbinary(max),documento),Extension from tbl_Examen where cod_examen = @id", conexion);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@id", Id);
                conexion.Open();
                SqlDataReader lector = comando.ExecuteReader();
                tabla.Load(lector);
                lector.Close();
                conexion.Close();
                return tabla;
            }

        }
    }
}
