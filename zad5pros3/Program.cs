using System;

namespace zad5pros3
{
    class Program
    {
        private class mikro
        {
            private int pojemnosc;
            public string kolor;
            protected int moc;
            public mikro()
            {
                pojemnosc = 20;
                kolor = "czarno-biały";
                moc = 700;
            }
            public mikro(mikro mikrofala)
            {
                Console.WriteLine("Działanie konstruktora kopiującego");
            }
            public void wartosc(int poj)
            {
                pojemnosc = poj;
                Console.WriteLine("Pojemność w metodzie z przekazaną wartością: " + pojemnosc + "\n");
            }
            public void referencja(ref int poj){
                pojemnosc = poj;
                Console.WriteLine("Pojemność w metodzie z przekazanym argumentem referencyjnie: " + pojemnosc + "\n");
            }

            public void wyswietl()
            {
                Console.WriteLine("Pojemność: " + pojemnosc);
                Console.WriteLine("Kolor: " + kolor);
                Console.WriteLine("Moc: " + moc+"\n");
            }
        }
        private class zmyw
        {
            private int wysokosc;
            public string eklasa;
            protected int szerokosc;
            public zmyw()
            {
                wysokosc = 85;
                eklasa = "A+++";
                szerokosc =60;
            }
            public zmyw(zmyw zmywarka)
            {
                Console.WriteLine("Działanie konstruktora kopiującego\n");
            }
            public void wartosc(int poj)
            {
                wysokosc = poj;
                Console.WriteLine("Pojemność w metodzie z przekazaną wartością: " + wysokosc + "\n");
            }
            public void referencja(ref int poj)
            {
                wysokosc = poj;
                Console.WriteLine("Pojemność w metodzie z przekazanym argumentem referencyjnie: " + wysokosc + "\n");
            }
            public void wyswietl()
            {
                Console.WriteLine("Wyskokość: " + wysokosc);
                Console.WriteLine("Klasa energetyczna: " + eklasa);
                Console.WriteLine("Szerokość: " + szerokosc+"\n");
            }
        }
        static void Main(string[] args)
        {
            int p;
            mikro mikrofala=new mikro();
            mikro fala2=new mikro(mikrofala);
            zmyw zmywarka = new zmyw();
            zmyw zmywacz = new zmyw(zmywarka);
            mikrofala.wyswietl();
            Console.WriteLine("Wpisz pojemnosc: ");
            p = int.Parse(Console.ReadLine());
            mikrofala.wartosc(p);
            mikrofala.wyswietl();
            Console.WriteLine("Wpisz pojemnosc: ");
            p = int.Parse(Console.ReadLine());
            mikrofala.referencja(ref p);
            mikrofala.wyswietl();
            Console.ReadLine();
        }
    }
}
