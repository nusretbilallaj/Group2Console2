using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2Console2
{
    internal class Profesor:Person
    {
        public Profesor(string emri, string mbiemri):base(emri,mbiemri)
        {

        }

        public void Pershendete()
        {
            Console.WriteLine($"Tungjatjet profesor {Emri} {Mbiemri}");
        }
    }
}
