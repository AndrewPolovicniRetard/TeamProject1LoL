using System;

namespace TeamProjectCsNejlepsi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            
            string finalSentence = "";

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
           

            
        }
    }
}
