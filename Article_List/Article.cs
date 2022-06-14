using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article_List
{
    internal class Article
    {
        public string titlu;
        public string[] autori;
        public string continut;
        public DateTime data_publicare;
        public DateTime data_update;
        public int likes;
        public int dislikes;
        public string[] tags; 
        public Article(string t, string[] a, string c, DateTime data1, DateTime data2, int l, int dl, string[] tags)
        {
            this.titlu = t;
            this.autori = a;
            this.continut = c;
            this.data_publicare = data1;
            this.data_update = data2;
            this.likes = l;
            this.dislikes = dl;
            this.tags = tags;
        }
        public static void Afisare(Article[] articles)
        {
            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append($"{titlu}; ");
            for (int i = 0; i < autori.Length; i++)
            {
                if(i>0) s.Append($", {autori[i]}");
                else s.Append($"{autori[i]} ");
            }
            s.Append($"; {continut}; {data_publicare:MM/dd/yyyy}; {data_update:MM/dd/yyyy}; {likes}; {dislikes}; ");
            for (int i = 0; i < tags.Length; i++)
            {
                if(i>0)
                s.Append($", {tags[i]}");
                else s.Append($"{tags[i]}");
            }
            return s.ToString();
        }
    }
}
