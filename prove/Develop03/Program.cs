using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "1 Nephi";
        int chapter = 3;
        int verse = 7;
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Scripture scripture = new Scripture(book, chapter, verse, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.DisplayScripture());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit" || scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.DisplayScripture(true)); // Replace words with underscores so that if the program can't find 3 words to replace it will just replace everything. This also replaces the words when the user types quit so they can jump to the end if they want.
                Console.WriteLine("Good Job! Program ending.");
                break;
            }

            scripture.HideRandomWords();
        }
    }

}
