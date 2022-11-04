using System.Collections.ObjectModel;

namespace Analyseur_Syntaxique
{
    class ExpressionArithmetique
    {
        private char plus;
        private char moins;
        private Terme terme;
        private ObservableCollection<Terme> termes;
        private ObservableCollection<char> lexique;

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
                        terme = new Terme(temp);
                        termes.Add(terme);
                        lexique.Add(expr[j]);
                        i = j + 1;
                        terme = null;
                        temp = "";
                    }
                }
            }
            if (temp!="")
            {
                terme = new Terme(temp);
                termes.Add(terme);
                terme = null;
            }
        }
    }
}
