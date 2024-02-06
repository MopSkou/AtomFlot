using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomFlot
{
    public class Berthing
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }

        public string NameKor { get; set; }
        public string NameKop { get; set; }
        public int Port { get; set; }
        public string Posechenie { get; set; }
    }
}
