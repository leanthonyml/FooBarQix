using System;

namespace FooBarQix
{
    internal class Translator
    {
        public Translator()
        {
        }

        internal string Translate(string input)
        {
            int number = Convert.ToInt32(input);
            string translated = "";

            if (number % 3 == 0)
                translated += "Foo";

            if ((number % 5 == 0))
                translated += "Bar";

            if ((number % 7 == 0))
                translated += "Qix";

            foreach (char letter in input)
            {
                if (translated != "")
                    if (letter == '0')
                        translated += "*";

                if (letter == '3')
                    translated += "Foo";

                if (letter == '5')
                    translated += "Bar";

                if (letter == '7')
                    translated += "Qix";
            }

            if (translated == "")
            {
                foreach (char letter in input)
                {
                    if (letter == '0')
                        translated += "*";
                    else
                        translated += letter;
                }
            }
            return translated;
        }
    }
}