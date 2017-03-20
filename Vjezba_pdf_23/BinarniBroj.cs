using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_pdf_23
{
    public class BinarniBroj
    {
        string binarniBroj ;
        int decimalnaVrijednost;
        public BinarniBroj(string broj)
        {
            binarniBroj = broj;
            if (broj.Length != 8)
            {
                throw new WrongBitNumber("Moraju biti brojevi s 8 bitova");
            }
            decimalnaVrijednost = 0;
            for (int i = 0; i < 8; i++)
            {
                decimalnaVrijednost += int.Parse(broj[i].ToString()) * (int)Math.Pow(2, 7 - i);
            }
        }
        public string Binarni()
        {
            return binarniBroj;
        }
        public int DecimalnaVrijednost()
        {
            return decimalnaVrijednost;
        }
    }
}
