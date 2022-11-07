namespace Analyseur_Syntaxique
{
    class Identificateur
    {
        private char firstLetter;
        private string corp;
        private const int MaxLength = 8;

        public Identificateur(string input)
        {
            Setup(input);
        }

        public Identificateur()
        {

        }

        private void Setup(string input)
        {
            firstLetter = input[0];
            corp = firstLetter.ToString();
            for (int i = 1; i != input.Length; i++)
            {
                corp += input[i];
            }
            if (corp.Length > MaxLength)
            {
                corp = corp.Substring(0, MaxLength);
            }
        }

        public override string ToString()
        {
            return corp;
        }
    }
}
