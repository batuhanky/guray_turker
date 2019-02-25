using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            int[] dizi = new int[4];
            int b_sayi = 0;
            Console.WriteLine("****BÜYÜK SAYI BULMA UYGULAMASI****");

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i + 1);
                dizi[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int j = 0; j < dizi.Length; j++)
            {
                for (int k = 1; k  < dizi.Length; k ++)
                {
                    if(dizi[k] > dizi[j])
                    {
                        b_sayi = dizi[k];
                    }
                }
            }
            Console.WriteLine("EN BÜYÜK SAYI = {0}", b_sayi);

        }
    }
}
