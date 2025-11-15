using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nefi", 3, 25);

        string text = "And now, blessed art thou, Joseph. Behold, thou art little; wherefore hearken unto the words of thy brother, Nephi, and it shall be done unto thee even according to the words which I have spoken. Remember the words of thy dying father. Amen.";
        Scripture scripture = new Scripture(reference, text);
        while(!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are hidden. The program has ended.");
    }    
}
