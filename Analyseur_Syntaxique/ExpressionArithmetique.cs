using System.Collections.ObjectModel;
using System.Linq;

namespace Analyseur_Syntaxique
{
    class ExpressionArithmetique
    {
        private readonly char plus;
        private readonly char moins;
        private Terme terme;
        private readonly ObservableCollection<Terme> termes;
        private readonly ObservableCollection<char> lexique;

        public ExpressionArithmetique(string expr)
        {
            plus = '+';
            moins = '-';
            termes = new ObservableCollection<Terme>();
            lexique = new ObservableCollection<char>();
            Setup(expr);
        }

        private void Setup(string expr)
        {
            string temp = "";
            for (int i = 0; i != expr.Length; i++)
            {
                temp += expr[i];
                if (i != expr.Length - 1)
                {
                    int j = i + 1;
                    if (expr[j] == plus || expr[j] == moins)
                    {
                        AddTerme(temp);
                        lexique.Add(expr[j]);
                        i = j + 1;
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                AddTerme(temp);
            }
        }

        private void AddTerme(string input)
        {
            terme = new Terme(input);
            termes.Add(terme);
            terme = null;
        }

        public override string ToString()
        {
            string retour = "";
            for (int i = 0; i != termes.Count; i++)
            {
                retour += termes.ElementAt(i).ToString();
                if (lexique.Count > i)
                {
                    retour += lexique.ElementAt(i);
                }
            }
            return retour;
        }
    }
}
