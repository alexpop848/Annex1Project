class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 10)
        {

            Console.WriteLine("Please enter a string:");
            string inputString = Console.ReadLine();

            if (string.IsNullOrEmpty(inputString))  //we use the if statement to check if the user actually entered a string
            {
                Console.WriteLine("String cannot be empty! Please add another string: ");
                inputString = Console.ReadLine();

            }

            Console.WriteLine("Please choose an option from the menu below:");
            Console.WriteLine("1. Convert string to uppercase");
            Console.WriteLine("2. Reverse string");
            Console.WriteLine("3. Count number of vowels in string");
            Console.WriteLine("4. Count number of words in string");
            Console.WriteLine("5. Convert string to title case");
            Console.WriteLine("");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Uppercase: " + inputString.ToUpper());
                    break;
                case "2":
                    Console.WriteLine("Reversed: " + ReverseString(inputString));
                    break;
                case "3":
                    int vowelCount = CountVowels(inputString);
                    Console.WriteLine("Number of vowels: " + vowelCount);
                    break;
                case "4":
                    int wordCount = CountWords(inputString);
                    Console.WriteLine("Number of words: " + wordCount);
                    break;
                case "5":
                    Console.WriteLine("Title case: " + ToTitleCase(inputString));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            i++;
            Console.WriteLine("");
        }

        Console.ReadLine();


    }

    static string ReverseString(string input)  //the function takes a single argument ('input'), which represents a string containing some text
    {
        string charArray, reverse = "";
        charArray = input;
        for (int i = charArray.Length - 1; i >= 0; i--)  //iterates over each character of the string from the last to first
        {
            reverse += charArray[i];
        }
        if (charArray == reverse)
        {
            Console.WriteLine("The string is a palindrome");
        }
        return reverse;
    }

    static int CountVowels(string input)
    {
        int count = 0;  //we initialize the 'count' variable to 0
        string vowels = "aeiouAEIOU";

        foreach (char c in input)  //we use the foreach loop to iterate over each character in the input string
        {
            if (vowels.IndexOf(c) != -1)  //using the IndexOf method, the function checks each character to see if it is a vowel
            {                             //if the method returns a value other than -1, it means that the character is a vowel 

                count++; //the function increments the 'count' variable by 1
            }
        }

        return count;
    }

    static int CountWords(string input)
    {
        int count = 0;
        string[] words = input.Split();  //By default, the Split method splits the string at each whitespace character

        foreach (string word in words)
        {
            count++;
        }

        return count;
    }

    static string ToTitleCase(string input)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input);
        //CultureInfo.CurrentCulture is a property that returns a CultureInfo object that represents
        //the culture of the operating system on which the application is running.
        //The TextInfo property provides access to the text-related properties and methods specific to that culture.
    }
}
