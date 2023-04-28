using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Case2
{
    static class Hmm
    {

        public static string[,] lærerarray = new string[1,4]
         {
            {"Niels Olesen", "Flemming Sørensen", "Peter Lindenskov", "Henrik Poulsen"}
         };
        public static string[,] elevarray = new string[4,4]
         {
            {"Alexander Thamdru", "Allan Gawron", "Andreas Balle", "Darab Haqnazar"},
            {"Felix Beger", "Jamie D", "Jeppe Pedersen", "Joseph Hale"},
            {"Kamil Kulpa", "Loke Bendtsen", "Mark Larsen", "Niklas Jensen"},
            {"Rasmus Hjorth", "Sammy Damiri", "Thomas Holmberg", "Tobias Besser"}
         };
        public static string[,] fagarray = new string[1,7]
         {
            {"Studieteknik", "Grundlæggende Programmering", "Databseprogram", "OOP", "Computerteknologi", "Clientsideprogrammering", "Netværk"}
         };

        
    }
}
