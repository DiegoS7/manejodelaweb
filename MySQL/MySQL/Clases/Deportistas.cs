using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite; //Agregamos libreria

namespace MySQL.Clases
{
    class Deportistas
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Deporte { get; set; }
        public string Edad { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - {Deporte} - {Edad}";
        }
    }
}
