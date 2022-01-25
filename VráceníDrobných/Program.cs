using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VráceníDrobných
{
    class Program
    {
        static void Main(string[] args)
        {
            // input ceny produktu a jakou částkou kupující zaplatil 
            int cena;
            int zaplaceno;
            Console.Write("Cena: ");
            cena = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zaplaceno: ");
            zaplaceno = Convert.ToInt32(Console.ReadLine());
            // suma na vrácení, se kterou budeme počítat
            int rozdil = zaplaceno - cena;


            // počítání pokud peněz na vrácení je více jak 50,- Kč
            if (rozdil > 50)
            {
                int padesat = rozdil / 50;
                int rozdil1 = rozdil - padesat * 50;

                int dvacet = rozdil1 / 20;
                int rozdil2 = rozdil1 - dvacet * 20;

                int deset = rozdil2 / 10;
                int rozdil3 = rozdil2 - deset * 10;

                int pet = rozdil3 / 5;
                int rozdil4 = rozdil3 - pet * 5;

                int dva = rozdil4 / 2;
                int rozdil5 = rozdil4 - dva * 2;

                int jedna = rozdil5 / 1;
                int rozdil6 = rozdil5 - jedna * 1;

                // výpis
                Console.WriteLine("");
                Console.WriteLine("Na vrácení: " + rozdil);
                Console.WriteLine("50 Kč: " + padesat + " Ks");
                Console.WriteLine("20 Kč: " + dvacet + " Ks");
                Console.WriteLine("10 Kč: " + deset + " Ks");
                Console.WriteLine("5 Kč: " + pet + " Ks");
                Console.WriteLine("2 Kč: " + dva + " Ks");
                Console.WriteLine("1 Kč: " + jedna + " Ks");
            }
            // počítání pokud peněz na vrácení je méně jak 50,- Kč
            else
            {
                int padesat = 0;
                int dvacet = rozdil / 20;
                int rozdil1 = rozdil - dvacet * 20;

                int deset = rozdil1 / 10;
                int rozdil2 = rozdil1 - deset * 10;

                int pet = rozdil2 / 5;
                int rozdil3 = rozdil2 - pet * 5;

                int dva = rozdil3 / 2;
                int rozdil4 = rozdil3 - dva * 2;

                int jedna = rozdil4 / 1;
                int rozdil5 = rozdil4 - jedna * 1;

                // výpis
                Console.WriteLine("");
                Console.WriteLine("Na vrácení: " + rozdil);
                Console.WriteLine("50 Kč: " + padesat + " Ks");
                Console.WriteLine("20 Kč: " + dvacet + " Ks");
                Console.WriteLine("10 Kč: " + deset + " Ks");
                Console.WriteLine("5 Kč: " + pet + " Ks");
                Console.WriteLine("2 Kč: " + dva + " Ks");
                Console.WriteLine("1 Kč: " + jedna + " Ks");
            }
            Console.ReadKey();


        }
    }
}
