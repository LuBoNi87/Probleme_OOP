using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesare_Caractere
{
    internal class Program
    {
        static void Main()
        {
            TextFile textFile = new TextFile(@"..\..\TextFile1.txt");
            Console.WriteLine($"\tNumar Linii: {textFile.nrLinii}" +
                $"\n\tNumar Caractere: {textFile.NumarCaractere()}" +
                $"\n\tNumar Vocale: {textFile.NumarVocale()}" +
                $"\n\tNumar Consoane: {textFile.NumarConsoane()}");
        }
    }
}
