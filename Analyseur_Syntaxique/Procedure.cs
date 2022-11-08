using System;

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
                            Console.WriteLine("Erreur: L'identificateur de début n'a pas de lettre comme premier caractère.");
                            Environment.Exit(0);
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
                    else if (temp == "Fin_Procedure ")
                    {
                        temp = "";
                    }
                    else if (proc.Substring(i + 1, 13) == "Fin_Procedure" && declarations != null)
                    {
                        instructions = new InstructionsAffectation(temp);
                        temp = "";
                    }
                }
                else if (i == proc.Length - 1)
                {
                    end = temp;
                    if (end != start.ToString())
                    {
                        Console.WriteLine("Erreur: L'identificateur de fin n'était pas le même que celui du début.");
                        Environment.Exit(0);
                    }
                }
            }
        }

        public override string ToString()
        {
            return start.ToString() + declarations.ToString() + instructions.ToString() + end;
        }
    }
}
