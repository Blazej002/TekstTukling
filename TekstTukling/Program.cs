using static System.Net.Mime.MediaTypeNames;

namespace TekstTukling;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Reverse tekst   2. Change word");
            var userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                Console.WriteLine("Write in the word!");
                var tekst = Console.ReadLine();
                var reverseText = RevText(tekst);
                Console.WriteLine(reverseText);
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Write in the word!");
                var text = Console.ReadLine();
                var difText = ChangeWord(text);
                Console.WriteLine(difText);
            }

            Console.ReadKey();
            Console.Clear();
        }
    }

    private static string ChangeWord(string? text)
    {
        if (text == null) return string.Empty;
        string result = "";
        for (int i = 0; i < (text.Length); i++)
        {
            char letter = text[i];
            if (letter == 'e')
            {
                result += 'a';
            }
            else if (letter == 'E')
            {
                result += "A";
            }
            else
            {
                result += letter;
            }
        }

        return result;
    }

    private static string RevText(string tekst)
    {
        if (tekst == null) return string.Empty;
        string revText = "";
        for (int i = (tekst.Length - 1); i >= 0; i--)
        {
            char c = tekst[i];
            revText += c;
        }

        return revText;
    }
}