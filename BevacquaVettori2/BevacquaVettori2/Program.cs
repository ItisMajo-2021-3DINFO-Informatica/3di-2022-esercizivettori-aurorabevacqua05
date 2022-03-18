using System;

namespace BevacquaVettori2
{
    class Program
    {
        static void Main(string[] args)
        {

            const int dimensione = 100;
            int[] vett = new int[dimensione];

            Random generatore = new Random();
            for(int i=0; i<dimensione; i++)
            {
                int numero= generatore.Next(1, 100);

               
                
                
                
                if (numero > 50)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Il numero non è disponibile");
                }
            }
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
