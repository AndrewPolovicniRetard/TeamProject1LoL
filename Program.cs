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
                string userInputA = Console.ReadLine();

                if (string.IsNullOrEmpty(userInputA))
                {
                    Console.WriteLine(finalSentence);
                    proceed = false;
                }
                else if (!string.IsNullOrEmpty(userInputA))
                {
                    finalSentence += userInputA;
                
                }
            }
           

            
        }
    }
}
