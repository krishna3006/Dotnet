using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmpEntity
{/// <summary>
/// Employ Entity Class
/// </summary>
/// [Serializable]
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public DateTime Doj { get; set; }
        public int Salary { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }


    }
}
