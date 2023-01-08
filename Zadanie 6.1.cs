namespace Zadanie
{
    class Program
    {
        public class Prostokat
        {
            private double szerokosc;
            private double dlugosc;
            private double powierzchnia;
            private double obwod;

            public double Powierzchnia 
            {
                get { return powierzchnia; }
                private set { powierzchnia = value; }
            }


            public double Obwod 
            {
                get { return obwod; }
                private set { obwod = value; }
            }

            public Prostokat(double szerokosc1, double dlugosc1) 
            {
                szerokosc = szerokosc1;
                dlugosc = dlugosc1;
                powierzchnia = this.Powierzchniamet(szerokosc, dlugosc);
                obwod = this.Obwodmet(szerokosc, dlugosc);
            }


            private double Powierzchniamet(double szer1, double dlug1)  
            {
                return szer1 * dlug1;
            }


            private double Obwodmet(double szer2, double dlug2) 
            {
                return 2 * (szer2 + dlug2);
            }


            public void Prezentuj()  
            {
                
                Console.WriteLine("powierzchnia: {0}, obwod: {1}", Powierzchnia,Obwod);
            }
        }


        static void Main(string[] args)
        {
            Prostokat pr1 = new Prostokat(2, 1);
            pr1.Prezentuj();
            Console.ReadKey();
        }
    }

}