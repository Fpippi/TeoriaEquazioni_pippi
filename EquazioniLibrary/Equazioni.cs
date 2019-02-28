using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double num1)
        {
            bool uscita = false;

            if (num1 != 0)
            {
                uscita = true;
            }

            return uscita;
        }
        public static bool IsInconsisted(double num1)
        {
            bool ritorno = false;

            if (num1 == 0)
            {
                ritorno = true;
            }

            return ritorno;
        }
    }
}
