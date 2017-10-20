using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaborationNmr3
{
    class Ordklass
    {
        public static List<string> Verb = new List<string>
        { "akta ","ansöka ","bada ","baka ","dansa ","dö ","elda ","fatta ","fråga ","förklara "};
        public static List<string> Adjektiv = new List<string>
        { "glad ","ljus ","varm ","dyr ","fin ","tidig ","känd ","spännande ","bra ","dålig "};
        public static List<string> Substantiv = new List<string>
        { "Olle ","Calle ","Maja ","Greta ","häst ","hund ","katt ","lycka ","sorg ","trötthet "};
        public static List<string> Adverb = new List<string>
        { "när ","där ","dit ","hit ","mycket ","lite ","snabbt ","långsamt ","ovanligt ","på "};

        public static void VerbMeny()
        {
            Console.Clear();
            int p = 1; //ordets nmr plats i menyn
            for (int i = 0; i < Verb.Count; i++, p++) //skriver ut List<string>
            {
                Console.Write(p); 
                Console.WriteLine(". {0}", Verb[i]);
            }

        }
        public static void AdjektivMeny()
        {
            Console.Clear();
            int p = 1;
            for (int i = 0; i < Adjektiv.Count; i++, p++)
            {
                Console.Write(p);
                Console.WriteLine(". {0}", Adjektiv[i]);
            }

        }
        public static void SubstantivMeny()
        {
            Console.Clear();
            int p = 1;
            for (int i = 0; i < Substantiv.Count; i++, p++)
            {
                Console.Write(p);
                Console.WriteLine(". {0}", Substantiv[i]);
            }

        }
        public static void AdverbMeny()
        {
            Console.Clear();
            int p = 1;
            for (int i = 0; i < Adverb.Count; i++, p++)
            {
                Console.Write(p);
                Console.WriteLine(". {0}", Adverb[i]);
            }

        }

    }
}
