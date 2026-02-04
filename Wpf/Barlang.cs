using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbázisbeolvasás
{
    internal class Barlang
    {
        public string Nev { get; set; }
        public double Hossz { get; set; }
        public double Kiterjedes { get; set; }
        public double Melyseg {  get; set; }

        public Barlang(MySql.Data.MySqlClient.MySqlDataReader reader)
        {
            this.Nev = reader.GetString("Nev");
            this.Hossz = reader.GetDouble("Hossz");
            this.Kiterjedes = reader.GetDouble("Kiterjedes");
            this.Melyseg = reader.GetDouble("Melyseg");
        }

    }
}
