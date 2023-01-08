namespace Zadanie
{
    class Program
    {
        public class ZuzyciePrad
        {
            public double poczotkowyStan;
            public double biezacyStan;
            public double zuzycie;

            public double PoczotkowyStan
            {
                get { return poczotkowyStan; }
                private set { poczotkowyStan = value; }
            }
            public double BiezacyStan
            {
                get { return biezacyStan; }
                private set { biezacyStan = value; }
            }

            public double Zuzycie
            {
                get { return zuzycie; }
                private set { zuzycie = value; }
            }

            public ZuzyciePrad(double prad1, double prad2)
            {
                poczotkowyStan = prad1;
                biezacyStan = prad2;
                zuzycie = this.Zuzycieprad(biezacyStan, poczotkowyStan);
                
            }


            private double Zuzycieprad(double prad1, double prad2)
            {
                return prad1 - prad2;
            }
            public void WyswietlLicznik()
            {

                Console.WriteLine("Początkowy stan licznika: {0}",poczotkowyStan + "kw");
                Console.WriteLine("Biezacy stan licznika: {0}", biezacyStan + "kw");
                Console.WriteLine("Zuzycie pradu: {0}", zuzycie + "kw");
            }
        }
        static void Main(string[] args)
        {
            double licznik1, licznik2;

            Console.WriteLine("Witaj w taryfie G12");
            Console.WriteLine("Podaj Poprzedni stan licznika: ");
            licznik1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj aktualny stan licznika: ");
            licznik2 = double.Parse(Console.ReadLine());
            ZuzyciePrad p1 = new ZuzyciePrad(licznik1, licznik2);
            p1.WyswietlLicznik();
            Console.ReadKey();
        }
    }

}


