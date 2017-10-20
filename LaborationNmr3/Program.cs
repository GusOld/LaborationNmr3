using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationNmr3
{
    class Program
    {
        /*
        static List<string> Verb = new List<string>
        { "akta","ansöka","bada","baka","dansa","dö","elda","fatta","fråga","förklara"};
        static List<string> Verb1 = new List<string>
        { "akta","ansöka","","","","","","","",""};
        static List<string> Verb2 = new List<string>
        { "akta","ansöka","","","","","","","",""};
        static List<string> Verb3 = new List<string>
        { "akta","ansöka","","","","","","","",""};
        */
        public static StringBuilder story = new StringBuilder();

        public static void Main(string[] args)
        {
            Introduction();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Din story: {0}", story);
                Meny();
                try
                {
                    int Read = int.Parse(Console.ReadLine());
                    if (Read == 1)
                    {
                        Ordklass.VerbMeny();
                        int read = int.Parse(Console.ReadLine()) - 1;
                        story.Append(Ordklass.Verb[read]);
                        Console.Clear();
                    }

                    else if (Read == 2)
                    {
                        Ordklass.SubstantivMeny();
                        int read = int.Parse(Console.ReadLine()) - 1;
                        story.Append(Ordklass.Substantiv[read]);
                        Console.Clear();
                    }
                    else if (Read == 3)
                    {
                        Ordklass.AdjektivMeny();
                        int read = int.Parse(Console.ReadLine()) - 1;
                        story.Append(Ordklass.Adjektiv[read]);
                        Console.Clear();
                    }
                    else if (Read == 4)
                    {
                        Ordklass.AdverbMeny();
                        int read = int.Parse(Console.ReadLine()) - 1;
                        story.Append(Ordklass.Adverb[read]);
                        Console.Clear();
                    }
                    else if (Read == 5)
                    {
                        string read = Console.ReadLine();
                        story.Append(read);
                        Console.Clear();
                    }
                    else if (Read == 6)
                        loop = false;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Välj mellan alternativen 1-6\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            Goodbye();

            /*
            int p = 1;
            for (int i = 0; i < Verb.Count; i++ ,p++)
            {
                Console.Write(p);
                Console.WriteLine(". {0}",Verb[i]);
            }
            */


        }
        public static void Introduction()
        {
            Console.Title = "Din Story";
            Console.WriteLine("Välkommen...");
            Console.ReadKey();
            Console.Clear();
          
        }
        public static void Meny()
        {
            string[] Ordklasser = new string[6] 
            { "1. Verb", "2. Adjektiv", "3. Substantiv", "4. Adverb","5. Fri text","6. Avsluta" };

            for (int i = 0; i < Ordklasser.Length; i++)
            {
                Console.WriteLine(Ordklasser[i]);
            }
            
        }
        public static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("Din story: {0}", story);
            Console.WriteLine("\nTryck på valfri knapp för att avsluta...");
            Console.ReadLine();
        }
        /*
        public static void VerbMeny()
        {
            Console.Clear();
            int p = 1;
            for (int i = 0; i < Verb.Count; i++, p++)
            {
                Console.Write(p);
                Console.WriteLine(". {0}", Verb[i]);
            }

        }
        */
    }
}
