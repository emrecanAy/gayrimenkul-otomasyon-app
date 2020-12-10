using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Emlak_Otomasyon
{
    class BaglantiSinif
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\SqlAdres.txt");
    }
}
