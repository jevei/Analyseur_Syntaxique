using System;

namespace Analyseur_Syntaxique
{
    class Program
    {
        static void Main(string[] args)
        {
            Procedure procedure = new Procedure("Procedure a12 declare b11 : entier ; b11 = 2 * 2 + 2 Fin_Procedure a12");
            Console.WriteLine(procedure.ToString());
        }
    }
}
