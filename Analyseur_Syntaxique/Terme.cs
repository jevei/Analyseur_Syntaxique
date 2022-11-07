using System.Collections.ObjectModel;
using System.Linq;

namespace Analyseur_Syntaxique
{
    class Terme
    {
        private readonly char mult;
        private readonly char divi;
        private Facteur facteur;
        private readonly ObservableCollection<Facteur> facteurs;
        private readonly ObservableCollection<char> lexique;

        public Terme(string input)
        {
            mult = '*';
            divi = '/';
            facteurs = new ObservableCollection<Facteur>();
            lexique = new ObservableCollection<char>();
            Setup(input);
        }

        private void Setup(string input)
        {
            string temp = "";
            for (int i = 0; i != input.Length; i++)
            {
                temp += input[i];
                if (i != input.Length - 1)
                {
                    int j = i + 1;
                    if (input[j] == mult || input[j] == divi)
                    {
                        AddFacteur(temp);
                        lexique.Add(input[j]);
                        i = j + 1;
                        temp = "";
                    }
                }
            }
            if (temp != "")
            {
                AddFacteur(temp);
            }
        }

        private void AddFacteur(string input)
        {
            facteur = new Facteur(input);
            facteurs.Add(facteur);
            facteur = null;
        }

        public override string ToString()
        {
            string retour = "";
            for (int i = 0; i != facteurs.Count; i++)
            {
                retour += facteurs.ElementAt(i).ToString();
                if (lexique.Count > i)
                {
                    retour += lexique.ElementAt(i);
                }
            }
            return retour;
        }
    }
}
