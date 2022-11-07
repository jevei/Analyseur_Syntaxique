using System.Collections.ObjectModel;
using System.Linq;

namespace Analyseur_Syntaxique
{
    class Declarations
    {
        private readonly ObservableCollection<Declaration> declarations;

        public Declarations()
        {

        }

        public Declarations(string input)
        {
            declarations = new ObservableCollection<Declaration>();
            Setup(input);
        }

        private void Setup(string input)
        {
            string declare = "";
            string var = "";
            string typ = "";
            string temp = "";
            for (int i = 0; i != input.Length; i++)
            {
                temp += input[i];
                int j = i - 1;
                if (input[i] == 32)
                {
                    if (declare == "")
                    {
                        declare = temp;
                        temp = "";
                    }
                    else if (var == "")
                    {
                        var = temp;
                        temp = "";
                    }
                    else if (input[j] == 58)
                    {
                        temp = "";
                    }
                    else if (typ == "")
                    {
                        typ = temp;
                        temp = "";
                    }
                }
                else if (input[i] == 59)
                {
                    declarations.Add(new Declaration(declare, var, typ));
                    declare = "";
                    var = "";
                    typ = "";
                    temp = "";
                    i++;
                }
            }
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i != declarations.Count; i++)
            {
                temp += declarations.ElementAt(i).ToString();
            }
            return temp;
        }
    }
}
