using System;

namespace BevacquaVettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int dimensione = 400;
            int[] num = new int[dimensione];

            Random generatore = new Random();           
            
            for(int i=0; i<dimensione; i++)
            {
                int numero = generatore.Next(1, 100);
                num[i] =numero;
                Console.WriteLine($"Numero{i}= {numero}");

           
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    }
}
