using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Anketa_File
{
    class Anketa
    { 
        public string Last_Name { get; set; }
        public string Name { get; set; }
        public string Father_Name { get; set; }

        public DateTime Birthday { get; set; }

        public Anketa()
        {
            this.Last_Name = "Last Name";
            this.Name = " Name";
            this.Father_Name = " Father Name";
            
        }

        public Anketa(string last_Name, string name, string father_Name, int day,int month,int year)
        {
            Last_Name = last_Name;
            Name = name;
            Father_Name = father_Name;
            Birthday = new DateTime(year, month, day);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}\n", Last_Name, Name, Father_Name, Birthday.ToShortDateString());
        }

    }
}
