using System;
namespace Uppgift_4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett heltal");
            int tal1 = int.Parse(Console.ReadLine());
            int störst = tal1;
            string svar = "";
            while (svar != "n")
            {
                Console.WriteLine("Vill du skriva in ett nytt heltal(Ja/nej)");
                string svar2 = Console.ReadLine();
                while (svar2 != "n")
                {
                    break;
                    if (störst > tal1)
                    {
                        Console.WriteLine(störst);
                    }
                }    

            }
           
        }
    }
}