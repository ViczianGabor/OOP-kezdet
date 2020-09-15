using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kezdet
{


    class teglalap
    {
        private int a;
        private int b;
        public teglalap(int aoldal,int boldal)
        {
            a = aoldal;
            b = boldal;
        }
        public int kerulet()
        {
            return 2 * (a + b);
        }

        public int terulet()
        {

            return a * b;

        }




    }
    class kor
    {
        int r;
      

        public void adatok()
        {

            Console.WriteLine("Sugár: {0}",r);
            Console.WriteLine("Kerület: {0}",keruletmetodus());
            Console.WriteLine("Terület: {0}",teruletmetodus());


        }

        public double keruletmetodus()
        {
            //Console.WriteLine("{0} vagyok és {1}éves",nev, eletkor);
            //lehetseges megoldas/rovidites return $"{nev} vagyok {eletkor} éves";
            //string valasz = $"{nev} vagyok {eletkor} éves";
            // return valasz;

            return 2 * r * Math.PI; 

        }
        public double teruletmetodus()
        {

            return Math.Pow(r,2) * Math.PI;

        }

        public kor(int sugar)
        {
            r = sugar;
            if (sugar<1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* teglalap Pisti = new teglalap();
             Pisti.nev = "Nagy Pisti";
             Pisti.eletkor = 20;
             Pisti.eletkor++;
             teglalap eva = new teglalap();
             eva.nev = "Nagy Éva";
             eva.eletkor = 18;
             */

            //  Console.WriteLine(Pisti.bemutatkozas());
            // Console.WriteLine(eva.bemutatkozas()); 

            /*
            Console.Write("Kérem a kör sugarát: ");
            int sugar = int.Parse(Console.ReadLine());
            kor t = new kor(sugar);
            
           // t.r = int.Parse(Console.ReadLine());
            
            

            Console.WriteLine(t.keruletmetodus());
            Console.WriteLine(t.teruletmetodus());
            */





            Console.Write("Téglalap a oldala: ");
            int aoldal = int.Parse(Console.ReadLine());
            Console.Write("Téglalap b oldala: ");
            int boldal = int.Parse(Console.ReadLine());
            teglalap k = new teglalap(aoldal,boldal);

            Console.WriteLine("Téglalap kerülete: {0} \t Téglalap Területe: {1}",k.kerulet(),k.terulet());



            Console.WriteLine("kör adatai: ");
            
            Console.ReadKey();
        }
    }
}
