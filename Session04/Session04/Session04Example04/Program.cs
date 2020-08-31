using System;

namespace Session04Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence of text, it contains many words.    ";

            string inputData = "   ";

            //Kontrollera om strängen är tilldelad ett värde.
            bool inputIsNull = inputData == null;
            bool inputIsEmpty = inputData == string.Empty;

            //Snabbmetoder för att kontrollera innehållet i en sträng.
            bool inputIsNullOrEmpty = string.IsNullOrEmpty(inputData);

            //Ytterligare kontroller om strängen innehåller vettig data.
            bool inputIsNullOrWhitespace = string.IsNullOrWhiteSpace(inputData);

            //Trimma bort mellanslag och andra whitespace-tecken från början och slutet.
            string trimmedSentenced = sentence.Trim();
            string endTrimmedSentenced = sentence.TrimEnd();

            //Det går att ange ett speciellt tecken som skall tas bort.
            string punctuationTrimmedSentenced = endTrimmedSentenced.TrimEnd('.');

            //Leta i text
            string searchForWord = "text";
            int indexOfText = trimmedSentenced.IndexOf(searchForWord);
            string subString = trimmedSentenced.Substring(indexOfText, searchForWord.Length);

            //ToUpper or ToLower(); språkinställningsberoende. man kan använda ToUpperInvarient(); istället.

            //Särkilt tecken.
            char oneCharacter = trimmedSentenced[0];

            for (int i = 0; i < trimmedSentenced.Length; i++)
            {
                //Loopa igenom en sträng, tecken för tecken.
                char currentChar = trimmedSentenced[i];
            }

            char[] trimmedSentencedCharArray = trimmedSentenced.ToCharArray();

            //Modifiera data.

            trimmedSentenced = new string(trimmedSentencedCharArray);

            trimmedSentenced = trimmedSentenced + "...";
            // samma sak som ovan
            trimmedSentenced += "...";

            // Sortera siffror från sträng till 001 , 002 osv
            // 001
            // 002
            // 023
            //Istället för 
            // 1
            // 2
            // 23
            // 3
            var numberInString = "12";
            var paddedNumberInString = numberInString.PadLeft('3','0');



        }
    }
}
