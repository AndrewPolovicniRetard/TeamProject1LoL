using System;

namespace TeamProjectCsNejlepsi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            
            string finalSentence = "";
            Console.WriteLine("<Zadejte vas vyber, pro 1 az 3 zadani(1/2/3)");
            Console.WriteLine("<PS: 2 zadani jsem rozdelil na 2 ruzne");
            Console.WriteLine("");
            string userInputChoice = Console.ReadLine();
            Console.Clear();
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
<<<<<<< HEAD
// ondra je kokot
=======
// Jsem to zvládnul - Matěj :D
>>>>>>> 49b75ae4ca9fe73b71285d66ab784dc76c060611
