using System;
using System.Windows.Input;

namespace IpProgetto
{
    class Program
    {
        static void Main(string[] args)
        {
            beginning:
            int[] IPottetto = new int[4];
            Console.WriteLine("Inserisci primo ottetto     ");
            IPottetto[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("====================================================================");
            Console.WriteLine("Inserisci secondo ottetto   ");
            IPottetto[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("====================================================================");
            Console.WriteLine("Inserisci terzo ottetto     ");
            IPottetto[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("====================================================================");
            Console.WriteLine("Inserisci quarto ottetto    ");
            IPottetto[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("====================================================================");
            for (int i = 0; i < IPottetto.Length; i++)
            {
                if (IPottetto[i] < 0 || IPottetto[i] > 255)
                {
                    Console.WriteLine("Errore");
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("Premi R per restartare");
                    if (Console.ReadKey(true).Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        goto beginning;
                    }
                }
                else
                {
                    Console.WriteLine("Ip-valido, ora valutiamo il tipo di classe");
                    Console.WriteLine("====================================================================");
                    if (IPottetto[0] <= 127)
                    {
                        Console.WriteLine($"Il tuo indirizzo ip {IPottetto[0] + "." + IPottetto[1] + "." + IPottetto[2] + "." + IPottetto[3]} è di Classe A");
                        Console.WriteLine("====================================================================");
                    }
                    else if (IPottetto[0] <= 191 && IPottetto[0] >= 128)
                    {
                        Console.WriteLine($"Il tuo indirizzo ip {IPottetto[0] + "." + IPottetto[1] + "." + IPottetto[2] + "." + IPottetto[3]} è di Classe B");
                        Console.WriteLine("====================================================================");
                    }
                    else if (IPottetto[0] >= 192 && IPottetto[0] <= 223)
                    {
                        Console.WriteLine($"Il tuo indirizzo ip {IPottetto[0] + "." + IPottetto[1] + "." + IPottetto[2] + "." + IPottetto[3]} è di Classe C");
                        Console.WriteLine("====================================================================");
                    }
                    else if (IPottetto[0] >= 224 && IPottetto[0] <= 239)
                    {
                        Console.WriteLine($"Il tuo indirizzo ip {IPottetto[0] + "." + IPottetto[1] + "." + IPottetto[2] + "." + IPottetto[3]} è di Classe D");
                        Console.WriteLine("====================================================================");
                    }
                    else if (IPottetto[0] >= 240 && IPottetto[0] <= 255)
                    {
                        Console.WriteLine($"Il tuo indirizzo ip {IPottetto[0] + "." + IPottetto[1] + "." + IPottetto[2] + "." + IPottetto[3]} è di Classe E");
                        Console.WriteLine("====================================================================");
                    }
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("====================================================================");
                    Console.WriteLine("Premi R per restartare");
                    if (Console.ReadKey(true).Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        goto beginning;
                    }
                }
            }          
        }      
    }
}
