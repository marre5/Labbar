
Console.Write("Skriv in valfritt antal siffror och bokstäver: ");
string userInput = Console.ReadLine();

ulong totalAdded = 0;

for (int startIndex = 0; startIndex < userInput.Length; startIndex++)
{
    if (char.IsDigit(userInput[startIndex]))
    {
        for (int endIndex = startIndex + 1; endIndex < userInput.Length; endIndex++)
        {
            if (!char.IsDigit(userInput[endIndex]))
            {
                break;
            }

            if (userInput[startIndex] == userInput[endIndex])
            {
                string validString = userInput.Substring(startIndex, endIndex - startIndex + 1);

                bool isValidString = true;

                for (int i = 1; i < validString.Length - 1; i++)
                {
                    if (validString[i] == userInput[startIndex])
                    {
                        isValidString = false;
                        break;
                    }
                }
                if (isValidString)
                {
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (i == startIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(validString);
                            Console.ResetColor();
                            i = endIndex;
                        }
                        else
                        {
                            Console.Write(userInput[i]);
                        }
                    }
                    Console.WriteLine();

                    totalAdded += ulong.Parse(validString);
                }
            }
        }
    }

}

Console.WriteLine();
Console.WriteLine($"Totalen blir = {totalAdded}");
Console.ReadKey();