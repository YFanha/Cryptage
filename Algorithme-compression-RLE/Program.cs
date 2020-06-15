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
            int nbr = 0;

            Console.WriteLine("Tapez votre message : ");

            message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                for (int q = 0; q < message.Length  - i; q++)
                {
                    if (message[i] == message[q]) {
                        nombreChar++;
                        nbr++;
                    }
                }
                
                messageCompresser += nombreChar.ToString() + message[i];
                i += nbr;
                nbr = 0;
                nombreChar = 0;
            }
            Console.WriteLine("\n" + messageCompresser);

            Console.ReadKey();
        }
    }
}
