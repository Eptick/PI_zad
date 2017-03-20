using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_pdf_23
{
    public class WrongBitNumber : ApplicationException
    {
        public WrongBitNumber(string poruka)
        {
            DodatnaPoruka = poruka;
        }
        string DodatnaPoruka { get; set; }
    }
}
