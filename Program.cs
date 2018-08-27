using System;
using System.Collections.Generic;

namespace family_dictionary {
    class Program {
        static void Main (string[] args) {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>> ();

            myFamily.Add ("mother", new Dictionary<string, string> () { { "name", "Kimberly" }, { "age", "44" }
            });
            myFamily.Add ("brother", new Dictionary<string, string> () { { "name", "Ben" }, { "age", "20" }
            });
            myFamily.Add ("father", new Dictionary<string, string> () { { "name", "Tray" }, { "age", "44" }
            });
            myFamily.Add ("sister", new Dictionary<string, string> () { { "name", "Katherine" }, { "age", "18" }
            });

            foreach (KeyValuePair<string, Dictionary<string,string>> familyMember in myFamily) 
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
            }

        }
    }
}