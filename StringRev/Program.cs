namespace StringRev
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = "Good Morning"; // The original string
            string reversedWords = "";     // This will store the final reversed words
            string currentWord = "";       // This temporarily holds each word as we build it

            // Go through each character in the string one by one
            for (int i = 0; i < input.Length; i++)
            {
                // If the current character is not a space, add it to the current word
                if (input[i] != ' ')
                {
                    currentWord += input[i];
                }

                // If we find a space or reach the end of the string, it means a word is complete
                if (input[i] == ' ' || i == input.Length - 1)
                {
                    // Add the current word to the beginning of the reversedWords string
                    if (reversedWords == "")
                    {
                        reversedWords = currentWord; // First word goes directly into reversedWords
                    }
                    else
                    {
                        reversedWords = currentWord + " " + reversedWords; // Prepend the word
                    }

                    // Clear the currentWord so we can start building the next word
                    currentWord = "";
                }
            }

            // Print the final result with words in reverse order
            Console.WriteLine($"Reversed String : {reversedWords}");
        }
    }
}
