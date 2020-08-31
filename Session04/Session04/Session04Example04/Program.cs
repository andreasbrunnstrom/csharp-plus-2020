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
            string trimmedSentenced = sentence.Trim(); //TrimEnd() or TrimStart()
        }
    }
}
