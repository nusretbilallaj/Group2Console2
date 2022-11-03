using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2Console2
{
    internal class Person
    {
        public Person(string emri,string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

    }
}
