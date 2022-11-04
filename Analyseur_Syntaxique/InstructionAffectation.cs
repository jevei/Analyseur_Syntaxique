namespace Analyseur_Syntaxique
{
    class InstructionAffectation
    {
        private Variable variable;
        private ExpressionArithmetique expression;

        public InstructionAffectation(string var, string expr)
        {
            Setup(var, expr);
        }

        private void Setup(string var, string expr)
        {
            variable = new Variable(var);
            expression = new ExpressionArithmetique(expr);
        }

        public override string ToString()
        {
            return variable.ToString() + " = " + expression.ToString();
        }
    }
}
