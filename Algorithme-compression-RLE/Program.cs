using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            int nbr = 1;

            Console.WriteLine("Tapez votre message : ");

            message = Console.ReadLine() + " ";
            
            for(int i=0; i<message.Length-1; i++)
            {
                if(message[i] == message[i + 1])
                {
                    nbr++;
                }
                else
                {
                    messageCompresser += message[i];
                    messageCompresser += nbr;
                    nbr = 1;
                }
            }
            
            Console.WriteLine("\n" + messageCompresser);

            Console.ReadKey();
        }
    }
}
