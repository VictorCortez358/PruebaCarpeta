using System;

namespace CountersandAccumulators
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Insert n:");
           int n= Int32.Parse(Console.ReadLine());
           

           for(int altura= 1; altura<=n;altura++)
           {
               for(int espacio=n; espacio > altura;espacio--)
               {
                   Console.Write(espacio);
                   
               }
               for(int i=1; i<=(altura*2);i++)
               {
                   Console.Write(" ");
               }
               Console.WriteLine(" ");

           }  
        }     
   }
}

