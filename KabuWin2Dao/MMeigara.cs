using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KabuWin2Dao
{
    public class MMeigara
    {
        public int Id { get; set; }
        public string MeigaraCd { get; set; }
        public string MeigaraMei { get; set; }
        public Decimal TangenKabuSu { get; set; }
        public int ReitFlag { get; set; }
        public DateTime KikanStartDate { get; set; }
        public DateTime KikanEndDate { get; set; }
        public DateTime SakuseiDateTime { get; set; }
        public DateTime KoushinDateTime { get; set; }
    }
}
