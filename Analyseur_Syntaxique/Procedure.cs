namespace Analyseur_Syntaxique
{
    class Procedure
    {
        private Identificateur start;
        private Declarations declarations;
        private InstructionsAffectation instructions;
        private string end;

        public Procedure(string proc)
        {
            start = new Identificateur();
            declarations = new Declarations();
            instructions = new InstructionsAffectation();
            Setup(proc);
        }

        private void Setup(string proc)
        {
            string temp = "";
            for (int i = 0; i != proc.Length; i++)
            {
                temp += proc[i];
                if (proc[i] == 32)
                {
                    int j = i - 1;
                    if (temp == "Procedure ")
                    {
                        temp = "";
                    }
                    else if (start == null)
                    {
                        if ((temp[0] >= 65 && temp[0] <= 90) || (temp[0] >= 97 && temp[0] <= 122))
                        {
                            start = new Identificateur(temp);
                            temp = "";
                        }
                        else
                        {
                            ///TODO: ERREUR
                        }
                    }
                    else if (proc[j] == 59 && declarations == null)
                    {
                        if (proc.Substring(i + 1, 7) != "declare")
                        {
                            declarations = new Declarations(temp);
                            temp = "";
                        }
                    }
                    else if (proc.Substring(i + 1, 13) != "Fin_Procedure")
                    {
                        instructions = new InstructionsAffectation(temp);
                        temp = "";
                    }
                    else if (temp == "Fin_Procedure ")
                    {
                        temp = "";
                    }
                }
                else if (i == proc.Length - 1)
                {
                    end = temp;
                    if (end != start.ToString())
                    {
                        ///TODO: ERREUR
                    }
                }
            }
        }
    }
}
