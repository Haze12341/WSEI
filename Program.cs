using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            while (true)
            {
                string napis = Console.ReadLine();
                if ( napis==null || napis == ""  )
                {
                    break;
                }
                int liczba = int.Parse(napis);
                suma += liczba;
                Console.WriteLine(suma);
            }
        }
    }
}
