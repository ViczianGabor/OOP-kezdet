using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kezdet
{
    class kor
    {
        public double r;
      
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

            return r*r*Math.PI;

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

            kor t = new kor();
            t.r = int.Parse(Console.ReadLine());
            
            

            Console.WriteLine(t.keruletmetodus());
            Console.WriteLine(t.teruletmetodus());

            Console.ReadKey();
        }
    }
}
