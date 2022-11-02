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
            identificateur = new Identificateur(input);
        }
        
        public Identificateur GetIdentificateur()
        {
            return identificateur;
        }
    }
}
