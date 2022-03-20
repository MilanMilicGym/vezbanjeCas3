using System;

namespace vezbanjeCas3
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Uneti rezultat bicepsa :");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Uneti rezultat tricepsa: ");
            int drugiBroj = int.Parse(Console.ReadLine());


            Console.WriteLine("Uneti rezultat lopatice: ");
            int treciBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Uneti rezltat stomaka");
            int cetvrtiBroj = int.Parse(Console.ReadLine());

            int rezultatSabiranja = prviBroj + drugiBroj + treciBroj + cetvrtiBroj;
            Console.WriteLine("Rezultat sabiranja" + rezultatSabiranja);



            

        }
    }
} 
