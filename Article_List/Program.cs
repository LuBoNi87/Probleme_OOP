using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article[] articles = new Article[20];
            articles[0] = new Article("Luceafarul", new string[] { "Mihai Eminescu", "George Cosbuc" },"versuri",Convert.ToDateTime("04/25/1980"),
            Convert.ToDateTime("05/25/1980"),50,100,new string[] { "poezie", "litere" });
            articles[1] = new Article("Luceafarul", new string[] { "Mihai Eminescu", "George Cosbuc" }, "versuri", Convert.ToDateTime("04/25/1980"),
            Convert.ToDateTime("05/25/1980"), 50, 100, new string[] { "poezie", "cifre" });
            articles[2] = new Article("Luceafarul", new string[] { "Mihai Eminescu", "George Cosbuc" }, "versuri", Convert.ToDateTime("04/25/1980"),
            Convert.ToDateTime("05/25/1980"), 50, 100, new string[] { "poezie", "123" });
            Article.Afisare(articles);

        }
    }
}
