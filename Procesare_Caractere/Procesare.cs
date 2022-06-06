using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Procesare_Caractere
{
    internal class TextFile
    {
        string[] line = new string[10];
        string vowels = "aeiou";
        public int nrLinii;
        public TextFile(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            while (!streamReader.EndOfStream)
            line[nrLinii++] = streamReader.ReadLine();
        }
        public int NumarCaractere()
        {
            int nrCaractere=0;
            for (int i = 0; i < nrLinii; i++)
            {
                for (int j = 0; j < line[i].Length; j++)
                    nrCaractere++;
            }
            return nrCaractere;
        }
        public int NumarVocale()
        {
            int nrVocale = 0;
            for (int i = 0; i < nrLinii; i++)
            {
                for (int j = 0; j < line[i].Length; j++)
                        if (vowels.Contains(line[i][j]))
                            nrVocale++;
            }
            return nrVocale;
        }
        public int NumarConsoane()
        {
            int nrConsoane = 0;
            for (int i = 0; i < nrLinii; i++)
            {
                for (int j = 0; j < line[i].Length; j++)
                    if (line[i][j] >= 'A' && line[i][j] <= 'Z' || line[i][j] >= 'a' && line[i][j] <= 'z')
                        if (!vowels.Contains(line[i][j]))
                            nrConsoane++;
            }
            return nrConsoane;
        }
    }
}
