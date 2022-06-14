using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article_List
{
    internal class Program
    {
        static void Main()
        {
            Article[] articles = new Article[20];
            articles[0] = new Article("Doina", new string[] { "Vasile Alexandri"}, "doina", Convert.ToDateTime("03/27/1845"),
            Convert.ToDateTime("01/01/1848"), 70, 30, new string[] { "poezie", "doina" });
            articles[1] = new Article("Luceafarul", new string[] { "Mihai Eminescu", "George Cosbuc" },"versuri",Convert.ToDateTime("04/25/1880"),
            Convert.ToDateTime("05/30/1880"),50,100,new string[] { "poezie", "litere", "bac" });
            articles[2] = new Article("Lacul", new string[] { "Mihai Eminescu", "Octavian Goga" }, "versuri", Convert.ToDateTime("08/13/1877"),
            Convert.ToDateTime("03/09/1878"), 40, 50, new string[] { "poezie", "natura", "lacul" });
            articles[3] = new Article("Luceafarul", new string[] { "Mihai Eminescu", "George Cosbuc" }, "versuri", Convert.ToDateTime("04/25/1880"),
            Convert.ToDateTime("05/30/1880"), 51, 100, new string[] { "poezie", "litere", "bac" });
            Article.Afisare(articles);
            bool running = true;
            string operatie;
            string filtrare, sortare, agregare;
            List<string> aut = new List<string>();
            List<string> autori_art_publicate = new List<string>();
            List<string> taguri = new List<string>();
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i]!=null)
                for (int j = 0; j < articles[i].autori.Length; j++)
                {
                        if (!aut.Contains(articles[i].autori[j]))
                        {
                            aut.Add(articles[i].autori[j]);
                            autori_art_publicate.Add(articles[i].autori[j]);
                        }
                }
            }
            int[] articole_publicate = new int[aut.Count];
            int[] articole_publicate_ord = new int[aut.Count];
            for (int i = 0; i < aut.Count; i++)
            {
                foreach (var item in articles)
                {
                    if (item != null)
                        if (item.autori.Contains(aut[i]))
                        {
                            articole_publicate[i]++;
                            articole_publicate_ord[i]++;
                        }
                }
            }
            for (int i = 0; i < autori_art_publicate.Count-1; i++)
            {
                for (int j = i+1; j < autori_art_publicate.Count; j++)
                {
                    if (articole_publicate_ord[i] < articole_publicate_ord[j])
                    {
                        (articole_publicate_ord[j], articole_publicate_ord[i]) = (articole_publicate_ord[i], articole_publicate_ord[j]);
                        (autori_art_publicate[j], autori_art_publicate[i]) = (autori_art_publicate[i], autori_art_publicate[j]);
                    }
                }
            }
            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i] != null)
                    for (int j = 0; j < articles[i].tags.Length; j++)
                    {
                        if (!taguri.Contains(articles[i].tags[j]))
                            taguri.Add(articles[i].tags[j]);
                    }
            }
            while (running)
            {
                Console.Clear();
                Console.WriteLine("1. Filtrare\n2. Sortare\n3. Agregare");
                operatie = Console.ReadLine();
                switch (operatie)
                {
                    case "1":
                        running = true;
                        Console.Clear();
                        Console.WriteLine("1. sa se afiseze articolele scrise de un anumit autor.\n" +
                            "2. sa se afiseze articolele care un anumit tag\n" +
                            "3. sa se afiseze toate articolele publicate intr - un anumit interval - perioada de timp(data start - data final).\n" +
                            "4. sa se afiseze toate articolele publicate in weekend.");
                        filtrare = Console.ReadLine();
                        switch (filtrare)
                        {
                            case "1":
                                for (int i = 0; i < aut.Count; i++)
                                {
                                    Console.Write($"{i+1}. {aut[i]}\n");
                                }
                                int case1 = int.Parse(Console.ReadLine())-1;
                                foreach (var item in articles)
                                {
                                    if (item != null)
                                    if (item.autori.Contains(aut[case1]))
                                        Console.WriteLine(item);
                                }
                                break;
                            case "2":
                                for (int i = 0; i < taguri.Count; i++)
                                {
                                    Console.Write($"{i + 1}. {taguri[i]}\n");
                                }
                                int case2 = int.Parse(Console.ReadLine()) - 1;
                                foreach (var item in articles)
                                {
                                    if (item != null)
                                        if (item.tags.Contains(taguri[case2]))
                                            Console.WriteLine(item);
                                }
                                break;
                            case "3":
                                Console.WriteLine("Formatul datei: \"MM/DD/YYYY\" M-Month   D-Day   Y-Year");
                                DateTime date1, date2;
                                Console.Write("Data1:");
                                while(!DateTime.TryParse(Console.ReadLine(),out date1))
                                    Console.WriteLine("Data incorecta");
                                Console.Write("Data2:");
                                while (!DateTime.TryParse(Console.ReadLine(), out date2))
                                    Console.WriteLine("Data incorecta");
                                for (int i = 0; i < articles.Length; i++)
                                {
                                    if (articles[i]!=null)
                                    {
                                        if (articles[i].data_publicare >= date1 && articles[i].data_publicare <= date2)
                                            Console.WriteLine(articles[i]);
                                    }
                                }
                                Console.ReadKey();
                                break;
                            case "4":
                                for (int i = 0; i < articles.Length; i++)
                                {
                                    if (articles[i] != null)
                                        if (articles[i].data_publicare.DayOfWeek == DayOfWeek.Saturday || articles[i].data_publicare.DayOfWeek == DayOfWeek.Sunday)
                                            Console.WriteLine(articles[i]);
                                }
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        running = true;
                        Console.Clear();
                        Console.WriteLine("1. Sa se afiseze lista articolelor in ordine cronologica a aparitiei lor.\n" +
                            "2. Sa se afiseze lista articolelor in ordinea numarului de likes.\n" +
                            "3. Sa se afiseze lista tuturor autorilor in ordinea numarului de articole pe care le-au publicat.");
                        sortare = Console.ReadLine();
                        switch (sortare)
                        {
                            case "1":
                                Article[] articles1 = new Article[20];
                                for (int i = 0; i < articles.Length; i++)
                                {
                                    if(articles!=null)
                                    articles1[i] = articles[i];
                                }
                                for (int i = 0; i < articles1.Length-1; i++)
                                {
                                    for (int j = i+1; j < articles1.Length; j++)
                                    {
                                        if (articles1[i]!=null && articles1[j]!=null)
                                        if (articles1[i].data_publicare > articles1[j].data_publicare)
                                        {
                                            (articles1[j], articles1[i]) = (articles1[i], articles1[j]);
                                        }
                                    }
                                }
                                Article.Afisare(articles1);
                                Console.ReadKey();
                                break;
                            case "2":
                                Article[] articles2 = new Article[20];
                                for (int i = 0; i < articles.Length; i++)
                                {
                                    if (articles[i]!=null)
                                    articles2[i] = articles[i];
                                }
                                for (int i = 0; i < articles2.Length - 1; i++)
                                {
                                    for (int j = i + 1; j < articles2.Length; j++)
                                    {
                                        if (articles2[i]!=null && articles2[j]!=null)
                                        if (articles2[i].likes < articles2[j].likes)
                                        {
                                            (articles2[j], articles2[i]) = (articles2[i], articles2[j]);
                                        }
                                    }
                                }
                                Article.Afisare(articles2);
                                Console.ReadKey();
                                break;
                            case "3":
                                for (int i = 0; i < autori_art_publicate.Count; i++)
                                {
                                    Console.Write($"{autori_art_publicate[i]}\n");
                                }
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        running = true;
                        Console.Clear();
                        Console.WriteLine("1. Pentru fiecare autor afisez numarul de articole pe care le-a publicat fiecare" +
                            "\n2. Cate articole s - au publiat intr - un anumit intervat de timp(data start - data final)");
                        agregare = Console.ReadLine();
                        switch (agregare)
                        {
                            case "1":
                                for (int i = 0; i < aut.Count; i++)
                                {
                                    Console.WriteLine($"{aut[i]} - {articole_publicate[i]}");
                                }
                                Console.ReadKey();
                                break;
                            case "2":
                                int art_in_interval_timp = 0;
                                Console.WriteLine("Formatul datei: \"MM/DD/YYYY\" M-Month   D-Day   Y-Year");
                                DateTime date1, date2;
                                Console.Write("Data1:");
                                while (!DateTime.TryParse(Console.ReadLine(), out date1))
                                    Console.WriteLine("Data incorecta");
                                Console.Write("Data2:");
                                while (!DateTime.TryParse(Console.ReadLine(), out date2))
                                    Console.WriteLine("Data incorecta");
                                for (int i = 0; i < articles.Length; i++)
                                {
                                    if (articles[i] != null)
                                    {
                                        if (articles[i].data_publicare >= date1 && articles[i].data_publicare <= date2)
                                            art_in_interval_timp++;
                                    }
                                }
                                Console.WriteLine($"S-au publicat {art_in_interval_timp} articole in intervalul de timp {date1:MM/dd/yyyy} - {date2:MM/dd/yyyy}");
                                Console.ReadKey();
                                break;
                            default:
                                break;
                        }
                        Console.ReadKey();
                        break;
                    default:
                        running = false;
                        break;
                }
            }
        }
    }
}
