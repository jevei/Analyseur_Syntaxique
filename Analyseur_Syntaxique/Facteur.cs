using System;

namespace Analyseur_Syntaxique
{
    class Facteur
    {
        private readonly char droite;
        private readonly char gauche;
        private readonly char firstChar;
        private Nombre number;
        private Variable variable;
        private ExpressionArithmetique expression;

        public Facteur(string input)
        {
            droite = (char)41;
            gauche = (char)40;
            firstChar = input[0];
            Setup(input);
        }

        private void Setup(string input)
        {
            if (firstChar == gauche)
            {
                string temp = "";
                for (int i = 2; i != input.Length; i++)
                {
                    temp += input[i];
                    if (input[i] == droite)
                    {
                        temp = temp.Remove(i - 2);
                        expression = new ExpressionArithmetique(temp);
                    }
                    else if (i + 1 == input.Length)
                    {
                        Console.WriteLine("Erreur: Expression arithmétique entre parenthèse manque la parenthèse de droite.");
                        Environment.Exit(0);
                    }
                }
            }
            else if ((firstChar >= 65 && firstChar <= 90) || (firstChar >= 97 && firstChar <= 122))
            {
                variable = new Variable(input);
               /* if (!Program.variableList.Contains(variable))////TODO
                {
                    Console.WriteLine("Erreur: Variable " + variable.ToString() + " n'existe pas!");
                    Environment.Exit(0);
                }*/
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
                return gauche + expression.ToString() + droite;
            }
            else if ((firstChar >= 65 && firstChar <= 90) || (firstChar >= 97 && firstChar <= 122))
            {
                return variable.ToString();
            }
            else if (firstChar >= 48 && firstChar <= 57)
            {
                return number.ToString();
            }
            return "Nothing here!";
        }
    }
}
