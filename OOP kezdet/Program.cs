using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_kezdet
{
    class Ember
    {
        public string nev;
        public int eletkor;
        public string bemutatkozas()
        {
            //Console.WriteLine("{0} vagyok és {1}éves",nev, eletkor);
            //lehetseges megoldas/rovidites return $"{nev} vagyok {eletkor} éves";
            string valasz = $"{nev} vagyok {eletkor} éves";
            return valasz;
            
            

        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ember Pisti = new Ember();
            Pisti.nev = "Nagy Pisti";
            Pisti.eletkor = 20;
            Pisti.eletkor++;
            Ember eva = new Ember();
            eva.nev = "Nagy Éva";
            eva.eletkor = 18;


            Console.WriteLine(Pisti.bemutatkozas());
            Console.WriteLine(eva.bemutatkozas()); 

            Console.ReadKey();
        }
    }
}
