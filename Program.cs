using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinaryDecimal
{
    class Program
    {

        public static void CDeci_Bin(int value)
        {
            int aux;
            int[] bin = new int[1];

            for (int i = 0; value >= 1; value /= 2, i++)
            {
                aux = value % 2;
                if (aux == 0)
                {
                    bin[i] = 0;
                    Array.Resize(ref bin, bin.Length + 1);
                }
                else
                {
                    bin[i] = 1;
                    Array.Resize(ref bin, bin.Length + 1);
                }

            }

            for (int i = bin.Length - 2; i >= 0; i--)
            {
                aux = bin[i];
                Console.Write(bin[i]);
            }
        }

        public static void CBin_Deci(int value)
        {
            int newValue = 0, rest; ;

            for(double i = 0; value > 0; i++)
            {
                rest = value - ((value / 10) * 10);
                value = value / 10;
                newValue += rest * Convert.ToInt32(Math.Pow(2, i));
            }
            Console.Write("\n" + newValue);

        }
        static void Main(string[] args)
        {
            int num,num2=10;
            Console.WriteLine("Bem vindo!");
            num = Convert.ToInt32(Console.ReadLine());

            CDeci_Bin(num);
            CBin_Deci(num2);

            Console.ReadLine();
        }
    }

}
