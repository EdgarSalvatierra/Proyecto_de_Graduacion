using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.Model
{
    public class Examen_Class
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
    }
}
