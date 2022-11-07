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

        public override string ToString()
        {
            return identificateur.ToString();
        }
    }
}
