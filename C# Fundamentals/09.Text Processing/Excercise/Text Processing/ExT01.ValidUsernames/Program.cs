using System;

namespace ExT01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ");
            foreach (string currName in userNames)
            {
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    bool isUserNameValid = true;
                    foreach (char currChar in currName)
                    {
                        
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isUserNameValid = false;
                            break;
                        }
                    }
                    if (isUserNameValid)
                    {
                        Console.WriteLine(currName);
                    }
                }
            }
        }
    }
}
