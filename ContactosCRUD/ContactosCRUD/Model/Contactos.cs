using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactosCRUD.Model
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement, Unique]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cel_Numero { get; set; }
        public string Tel_Numero { get; set; }
        public string Direccion { get; set; }
        public string Fecha { get; set; }
        public int CategoryID { get; set; }
    }
}
