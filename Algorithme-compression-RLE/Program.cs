using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithme_compression_RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreChar = 0;
            string message = "";
            string messageCompresser = "";
            float tauxCompression;

            Console.WriteLine("Tapez votre message : ");

            message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                for (int q = 0; q < (message.Length - 1) - i; q++)
                {
                    if (message[i] == message[q]) nombreChar++;
                }
                messageCompresser += nombreChar.ToString() + message[i];

                nombreChar = 0;
            }
            Console.WriteLine("\n" + messageCompresser);

            Console.ReadKey();
        }
    }
}
