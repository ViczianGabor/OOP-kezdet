using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kezdet
{
    class teglalap
    {
        public int a;
        public int b;
        public int keruletmetodus()
        {
            //Console.WriteLine("{0} vagyok és {1}éves",nev, eletkor);
            //lehetseges megoldas/rovidites return $"{nev} vagyok {eletkor} éves";
            //string valasz = $"{nev} vagyok {eletkor} éves";
            // return valasz;
           
            return 2*a+2*b;

        }
        public int teruletmetodus()
        {
            
            return a*b;

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

            teglalap t = new teglalap();
            t.a = int.Parse(Console.ReadLine());
            
            t.b = int.Parse(Console.ReadLine());

            Console.WriteLine(t.keruletmetodus());
            Console.WriteLine(t.teruletmetodus());

            Console.ReadKey();
        }
    }
}
