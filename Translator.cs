using System;

namespace FooBarQix
{
    internal class Translator
    {
        public Translator()
        {
        }


        internal string BaseCases(int number, string translated)
        {

            if (number % 3 == 0)
                translated += "Foo";

            if ((number % 5 == 0))
                translated += "Bar";

            if ((number % 7 == 0))
                translated += "Qix";

            return translated;

        }

        internal string ExtraCases(string input, string translated)
        {
            foreach (char letter in input)
            {
                translated = ExtraCasesInternal(letter, translated);
            }

            return translated;
        }

        internal string ExtraCasesInternal(char letter, string translated)
        {
            if (translated != "" && letter == '0')
                    translated += "*";

            if (letter == '3')
                translated += "Foo";

            if (letter == '5')
                translated += "Bar";

            if (letter == '7')
                translated += "Qix";

            return translated;
        }

        internal string AsteriskCase(string input, string translated)
        {

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


        internal string Translate(string input)
        {
            int number = Convert.ToInt32(input);
            string translated = "";

            translated = BaseCases(number, translated);
            translated = ExtraCases(input, translated);
            translated = AsteriskCase(input,translated);

            return translated;
        }
    }
}