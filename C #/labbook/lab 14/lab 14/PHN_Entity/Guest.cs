using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHN_Entity
{
    public class Guest
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public Relation relationship { get; set; }
        public string ContactNumber { get; set; }

        public enum Relation { Father, Mother, Brother, Sister, Cousin, Uncle, Aunt, Son, Daughter, Friend }
    }
}
