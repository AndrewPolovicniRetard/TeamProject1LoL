using System;

namespace TeamProjectCsNejlepsi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            
            string finalSentence = "";

            string userInputChoice = Console.ReadLine();
            if (userInputChoice == "1")
            {
                while (proceed)
                {

                    if (proceed == true)
                    {
                        Console.WriteLine("<Zadejte slovo:");

                    }
                    string userInputA = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInputA))
                    {
                        Console.WriteLine(finalSentence);
                        proceed = false;
                    }
                    else if (!string.IsNullOrWhiteSpace(userInputA))
                    {
                        finalSentence += userInputA;

                    }
                }
            } else if (userInputChoice == "2")
            {
                int counter = 0;
                Console.WriteLine("<Zadejte slovo, ktere chcete zopakovat 5krat:");
                string userInputB = Console.ReadLine();
                while (proceed)
                {
                    
                    if (counter != 5){
                        Console.WriteLine(userInputB);
                        counter++;
                    }
                    else
                    {
                        proceed = false;
                    }
                }
                

            } else if (userInputChoice == "3")
            {

                for (int i = 1; i < int.MaxValue; i++)
                {
                    Console.WriteLine("<Zadejte slovo pro opakovani:");
                    string userInput2 = Console.ReadLine();
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine(userInput2);
                    }
                }
            }
        }
    }
}
