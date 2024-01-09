using Capa_Datos.Data.Examenes;
using Capa_Datos.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo.Model;

namespace Capa_Modelo.ViewModel
{
    public class Examen_Model 
    {
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


        ExamenesData examenes = new ExamenesData();

        public void InsertarExamenes(int cod_area, string nombre, byte[] Documento, string Extension, decimal precio)
        {
            examenes.Insertar(cod_area, nombre, Documento,Extension,precio);
        }
        public Object LeerExamen()
        {
            return examenes.Read();
        }
        public Object BuscarporExamen(string Examen)
        {
            return examenes.BuscarporExamen(Examen);
        }
       
        public List<Examen_Model> filtroDocumentos(int id)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=DBLaboratory;Integrated Security=True"))
            {
                var tabla = ArchivoId(id);
                var infoDocumennto = new List<Examen_Model>();

                foreach (DataRow item in tabla.Rows)
                {
                    infoDocumennto.Add(new Examen_Model
                    {
                        Id = Convert.ToInt32(item[0]),
                        Nombre = item[1].ToString(),
                        Documento = (byte[])item[2],
                        Extension = item[3].ToString()
                    });
                }
                return infoDocumennto;
            }                
        }

        public DataTable ArchivoId(int Id)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS01;Initial Catalog=DBLaboratory;Integrated Security=True"))
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
        public Object Cargar()
        {
            return examenes.CargarDatos();
        }
        public void ActualizarExamen(int cod_categoria, string nombre, decimal precio)
        {
            examenes.Update(cod_categoria, nombre, precio);
        }
        public void EliminarExamen(int codcategoria)
        {
            examenes.Delete(codcategoria);
        }
    }
}
