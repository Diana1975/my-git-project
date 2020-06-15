using System;

namespace NamuDarbai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Saskaita pagrindineSaskaita = new Saskaita();
            pagrindineSaskaita.Vardas = "Diana";
            pagrindineSaskaita.Pavarde = "Martinkeniene";
            pagrindineSaskaita.SaskaitosNumeris = "LT4350444688016060";
            pagrindineSaskaita.SaskaitosLikutis = 2000.00M;

           
            
           

            Tranzakcija tranzakcija1 = new Tranzakcija() { MokejimoSuma = 205.00M, MokejimoPaskirtis = "Paltas,parduotuve Zara",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija2 = new Tranzakcija() { MokejimoSuma = 25.30M, MokejimoPaskirtis = "Maistas, Lidl",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija3 = new Tranzakcija() { MokejimoSuma = 15.60M, MokejimoPaskirtis = "Prekes,Drogas",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija4 = new Tranzakcija() { MokejimoSuma = 55.50M, MokejimoPaskirtis = "Prekes, Ikea", Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija5 = new Tranzakcija() { MokejimoSuma = 105.00M, MokejimoPaskirtis = "Batai, Batu kalnas", Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija6 = new Tranzakcija() { MokejimoSuma = 19.90M, MokejimoPaskirtis = "Maistas, Maxima",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija7 = new Tranzakcija() { MokejimoSuma = 12.30M, MokejimoPaskirtis = "Prekes, Kika",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija8 = new Tranzakcija() { MokejimoSuma = 75.00M, MokejimoPaskirtis = "Kvepalai, Douglas",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija9 = new Tranzakcija() { MokejimoSuma = 35.00M, MokejimoPaskirtis = "Maistas, Iki",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija tranzakcija10 = new Tranzakcija() { MokejimoSuma = 15.40M, MokejimoPaskirtis = "Picca, PizzaExpress",  Valiuta = ValiutosTipas.EUR };
            Tranzakcija alga = new Tranzakcija() { MokejimoSuma = 1000.00M, MokejimoPaskirtis = "Darbo uzmokestis",  Valiuta = ValiutosTipas.EUR };


            pagrindineSaskaita.AtliktiMokejima(tranzakcija1);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija2);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija3);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija4);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija5);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija6);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija7);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija8);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija9);
            pagrindineSaskaita.AtliktiMokejima(tranzakcija10);
            pagrindineSaskaita.GautinosIplaukos(alga);


            pagrindineSaskaita.SaskaitosInfo();
           

            pagrindineSaskaita.AtspausdintiIsrasa();
           










            Console.ReadLine();
        }

    }
}
