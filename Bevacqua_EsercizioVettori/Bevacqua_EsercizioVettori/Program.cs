using System;

namespace Bevacqua_EsercizioVettori
{
    class Program
    {
        static void Main(string[] args)
        {

            int dimensione = 27;
            decimal[] prodotti = new decimal[dimensione];
            for(int i=0; i<dimensione; i++)
            {
                Console.WriteLine("Digita il prezzo dei prodotti: ");
                prodotti[i] = Convert.ToDecimal(Console.ReadLine());            
            }

            for(int i=0; i<dimensione; i++)
            {
                decimal sconto = prodotti[i] * 22 / 100;

                decimal prezzoScontato = prodotti[i] - sconto;
                Console.WriteLine($"");
            }
        
        
        
        
        
        
        
        }
    }
}
