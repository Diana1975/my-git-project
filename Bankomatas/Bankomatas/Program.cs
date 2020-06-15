using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace Bankomatas
{

    class Program
    {
        static int PIN = 78963;
        public decimal SaskaitosLikutis = 2000.00M;
        public static List<Transakciaja> transakciaja = new List<Transakciaja>();
        

        static void Main(string[] args)
        {
            PasirinktiKalba();
            PatikrintiKoda();
          

            Console.ReadLine();
        }

        static int IvestiPIN()
        {
            Console.WriteLine("Iveskite PIN koda.");
            int ivestasPIN = Convert.ToInt32(Console.ReadLine());
            return ivestasPIN;
        }

        static bool PatikrintiKoda()
        {
            int ivestasKodas = IvestiPIN();
            bool teisingasPIN = false;

            for (int i = 1; i <= 3; i++)
            {
                if (ivestasKodas != PIN && i < 3)
                {
                    Console.WriteLine("PIN neteisingas, bandykite dar karta");
                    ivestasKodas = Convert.ToInt32(Console.ReadLine());
                }
                else if (ivestasKodas != PIN && i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("PIN neteisingas,kortele uzblokuota");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" PIN kodas teisingas.");
                    teisingasPIN = true;
                    Meniu();
                }
            }
            return teisingasPIN;
        }

        static void Meniu()
        {
            Console.WriteLine(" MENIU:\n 1.Keisti kalba;\n 2.Keisti PIN koda; \n 3.Sasakitos likutis; \n 4.Saskaitos israsas; " +
            " \n 5.Inesti pinigus;\n 6.Pasiimtipinigus;\n 7.Baigtidarba;");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas)
            {
                case 1:
                    //PakeistiKalba();
                    break;
                case 2:
                    PakeistiPIN();
                    break;
                case 3:
                    SaskaitosLikutis();
                    break;
                case 4:
                    //SaskaitosIsrasas();
                    break;
                case 5:
                    InestiPinigus();
                    break;
                case 6:
                    //InestiPinigus();
                    break;
                case 7:
                    Console.WriteLine("Baigiam darba");
                    Environment.Exit(0);
                    break;
            }

        }

        static void PakeistiPIN()
        {
            Console.WriteLine("Iveskite galiojanti PIN koda");
            int naujasKodas = Convert.ToInt32(Console.ReadLine());
            if (naujasKodas == PIN)
            {
                Console.WriteLine("Keisti PIN koda");
                Console.WriteLine("Iveskite nauja koda is keturiu skaitmenu");
                int naujasPIN = Convert.ToInt32(Console.ReadLine().Length);

                if (naujasPIN == 4)
                {
                    PIN = naujasPIN;

                    Console.WriteLine("Jusu kodo ilgis tinkamas.Kodas pakeistas");
                }
                else
                {
                    Console.WriteLine("Jusu ivestas kodas netinkamo ilgio. Iveskite koda is keturiu skaitmenu");
                }
            } Meniu();
        }

        static void PasirinktiKalba()
        {

            Console.WriteLine("Sveiki,\n Pasirinkite kalba:\n 1 - LT \n 2 - EN \n 3 - RUS");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            if (pasirinkimas == 1)
            {
                Console.Clear();
                Console.WriteLine("Sveiki!");
            }
            else if (pasirinkimas == 2)
            {
                Console.Clear();
                Console.WriteLine("Hallo!");
            }
            else if (pasirinkimas == 3)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Pakeisti kalba ");

               Meniu();
            }
        }

        public void SaskaitosLikutis()
        {
            Console.WriteLine($"Saskaitos likutis: {2000.00} eur");
            
            Meniu();
        }
        

        
    }
}













































