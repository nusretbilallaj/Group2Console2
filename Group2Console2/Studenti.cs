using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2Console2
{
    internal class Studenti:Person
    {
        public Studenti(string emri,string mbiemri, int mosha, string adresa):base(emri, mbiemri)
        {
            Mosha=mosha;
            Adresa=adresa;
        }


        public int Mosha { get; set; }
        public string Adresa { get; set; }

        public void Pershendete()
        {
            Console.WriteLine($"Tungjatjeta student {Emri} {Mbiemri}");
        }

    }
}
