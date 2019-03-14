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
        public static bool IsInconsisted(double num1 ,double num2)
        {
            bool ritorno = false;

            if (num1 == 0)
            {
                if (num2 == 0)
                {
                    ritorno = true;
                }
            }

            return ritorno;
        }
        public static bool IsDegree2(double num1)
        {
            bool ritorno = true;

            if (num1 == 0)
            {
                ritorno = false;
            }

            return ritorno;
        }

        public static double Delta(double num1,double num2,double num3)
        {
            return (num2 * num2) - (4 * num1 * num3);
        }

        public static string EquationDegree1(double num1,double num2)
        {
            

            if (IsInconsisted(num1,num2))
            {
                 return "indeterminata";
            }else if (!IsDetermined(num1))
            {
                return  "impossibile";
            }
            else
            {
                double calcolo= (-num2 / num1);
                 return Convert.ToString(calcolo);
            }
               
            
            
        }
        
        
    }
}
