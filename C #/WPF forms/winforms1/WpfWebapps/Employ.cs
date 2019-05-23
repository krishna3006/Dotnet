using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWebapps
{
   public class Employ
    {
        List<Employ> lstEmploy = new List<Employ>()
        {
            new Employ{Empno=1,name="Bhargav",Basic=25646},
            new Employ{Empno=2,name="Krishna",Basic=65682},
            new Employ{Empno=3,name="Naga",Basic=64655},
            new Employ{Empno=4,name="Arun",Basic=65656},
            new Employ{Empno=5,name="Sada",Basic=25659}
        };
        public List<Employ>GetEmploy()
        {
            return lstEmploy;
        }
    }
}
