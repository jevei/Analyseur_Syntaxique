namespace Analyseur_Syntaxique
{
    class Nombre
    {
        private string preVirgule;
        private string postVirgule;
        private string number;

        public Nombre(string input)
        {
            Setup(input);
        }

        private void Setup(string input)
        {

            bool virgule = false;
            preVirgule = "";
            postVirgule = "";
            for (int i = 0; i != input.Length; i++)
            {
                if (virgule == false)
                {
                    preVirgule += input[i];
                }
                else if (input[i] == ',')
                {
                    virgule = true;
                }
                else
                {
                    postVirgule += input[i];
                }
            }
            switch (virgule)
            {
                case true:
                    number = preVirgule + ',' + postVirgule;
                    break;
                case false:
                    number = preVirgule;
                    break;
            }
        }

        public override string ToString()
        {
            return number;
        }
    }
}
