using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationNmr3
{
    class Program
    {
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
                        int read = int.Parse(Console.ReadLine()) - 1; //subtraherar 1 för att välja rätt platt i Listan Verb
                        story.Append(Ordklass.Verb[read]); // skickar ord till stringbuilder objektet "story"
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
                catch (Exception e) //fångar felaktiga inputs
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            Goodbye();
        }
        public static void Introduction()
        {   //berättar appens syfte
            Console.Title = "Din Story"; 
            Console.WriteLine("Välkommen till Din Story!");
            Console.WriteLine("Här kan du med hjälp av våran stora ord-arsenal och \nditt egna bottenlösa hjärnkontor skapa din alldeles egna historia");
            Console.WriteLine("\nTryck på valfri knapp för att starta äventyret..");
            Console.ReadKey();
            Console.Clear();
          
        }
        public static void Meny()
        {
            string[] MenyAlt = new string[6] //Huvudmenyns alternativ
            { "1. Verb", "2. Adjektiv", "3. Substantiv", "4. Adverb","5. Fri text","6. Avsluta" };

            for (int i = 0; i < MenyAlt.Length; i++) //Skriver ut den Huvudmenyn
            {
                Console.WriteLine(MenyAlt[i]);
            }
            
        }
        public static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("Din story: {0}", story); // skriver ut din färdiga story
            Console.WriteLine("\nTryck på valfri knapp för att avsluta...");
            Console.ReadLine();
        }
    }
}
