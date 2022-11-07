using System.Collections.ObjectModel;

namespace Analyseur_Syntaxique
{
    class InstructionsAffectation
    {
        private readonly ObservableCollection<InstructionAffectation> instructions;

        public InstructionsAffectation()
        {

        }

        public InstructionsAffectation(string input)
        {
            instructions = new ObservableCollection<InstructionAffectation>();
            Setup(input);
        }

        private void Setup(string input)
        {
            string var = "";
            string expr = "";
            string temp = "";
            for (int i = 0; i != input.Length; i++)
            {
                temp += input[i];
                int j = i - 1;
                if (input[i] == 32)
                {
                    if (var == "")
                    {
                        var = temp;
                        temp = "";
                    }
                    else if (input[j] == 61)
                    {
                        temp = "";
                    }
                }
                else if (input[i] == 59)
                {
                    expr = temp;
                    instructions.Add(new InstructionAffectation(var, expr));
                    temp = "";
                }
            }
            instructions.Add(new InstructionAffectation(var, temp));
        }
    }
}
