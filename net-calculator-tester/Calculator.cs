using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        // Addizione
        public static float Add(float  num1, float num2)
        {
            return num1 + num2;
        }

        // Sottrazione
        public static float Substract(float num1, float num2)
        {
            return num1 - num2;
        }

        // Divisione
        public static float Divide(float num1, float num2)
        {
            if (num1 == 0 && num2 == 0) throw new Exception("Impossibile dividere per 0");
            return num1 / num2;
        }

        // Moltiplicazione
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        // Elevamento a potenza
        public static float Eleva(float numBase, float esponente)
        {
            if (numBase == 0 || esponente == 0)
                return 1;

            float risultato = 1;
            float numBase2 = numBase;

            if (esponente < 0)
                numBase2 = (float)(1.0 / numBase2);

            for (int i = 0; i < Math.Abs(esponente); i++)
                risultato *= numBase2;

            return risultato;

        }
    }
}
