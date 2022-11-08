using System;

namespace Analyseur_Syntaxique
{
    class Variable
    {
        private Identificateur identificateur;

        public Variable(string input)
        {
            Setup(input);
        }

        private void Setup(string input)
        {
            if ((input[0] >= 65 && input[0] <= 90) || (input[0] >= 97 && input[0] <= 122))
            {
                identificateur = new Identificateur(input);
            }
            else
            {
                Console.WriteLine("Erreur: L'identificateur " + input + " n'a pas de lettre comme premier caractère.");
                Environment.Exit(0);
            }
        }

        public Identificateur GetIdentificateur()
        {
            return identificateur;
        }

        public override string ToString()
        {
            return identificateur.ToString();
        }
    }
}
