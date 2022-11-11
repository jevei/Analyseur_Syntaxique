using System;
using System.Collections.Generic;

namespace Analyseur_Syntaxique
{
    class Program
    {
        public static List<Variable> variableList;

        static void Main(string[] args)
        {
            ////TODO: Toute variable utilisée dans une expression doit être préalablement déclarée.
            variableList = new List<Variable>();
            Procedure procedure = new Procedure("Procedure a12 declare b11 : entier ; b11 = 2 * ( 2 * 2 + 2 ) ; c23 = 2 * 2 + 2 Fin_Procedure a12");
            Console.WriteLine(procedure.ToString());
        }
    }
}
