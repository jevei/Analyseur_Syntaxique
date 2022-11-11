namespace Analyseur_Syntaxique
{
    class Declaration
    {
        private Variable variable;
        private string declare;
        private Type type;

        public Declaration(string decla, string var, string typ)
        {
            Setup(decla, var, typ);
        }

        private void Setup(string decla, string var, string typ)
        {
            declare = decla;
            variable = new Variable(var);
            Program.variableList.Add(variable);
            switch (typ)
            {
                case "entier":
                    type = Type.entier;
                    break;
                case "reel":
                    type = Type.reel;
                    break;
            }
        }

        public override string ToString()
        {
            return declare + " " + variable.ToString() + " : " + type.ToString() + ";";
        }
    }
}
