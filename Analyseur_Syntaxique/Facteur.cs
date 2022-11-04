namespace Analyseur_Syntaxique
{
    class Facteur
    {
        /*private readonly char droite;
        private readonly char gauche;*/
        private char firstChar;
        private Nombre number;
        //private Variable variable;
        //private ExpressionArithmetique expression;

        public Facteur(string input)
        {
            /*droite = ')';
            gauche = '(';*/
            Setup(input);
        }

        private void Setup(string input)
        {
            firstChar = input[0];
            if (firstChar == '(')
            {
                ///TODO: Facteur.expression
            }
            else if ((firstChar >= 65 && firstChar <= 90) || (firstChar >= 97 && firstChar <= 122))
            {
                ///TODO: Facteur.variable
            }
            else if (firstChar >= 48 && firstChar <= 57)
            {
                number = new Nombre(input);
            }
        }

        public override string ToString()
        {
            if (firstChar == '(')
            {
                ///TODO: Facteur.expression.ToString
                return "PLACEHOLDER";
            }
            else if ((firstChar >= 65 && firstChar <= 90) || (firstChar >= 97 && firstChar <= 122))
            {
                ///TODO: Facteur.variable.ToString
                return "PLACEHOLDER";
            }
            else if (firstChar >= 48 && firstChar <= 57)
            {
                return number.ToString();
            }
            return "Nothing here!";
        }
    }
}
