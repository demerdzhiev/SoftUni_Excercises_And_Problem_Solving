using System;

namespace ExT07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1 => reading the input 
            string textField = Console.ReadLine(); // abv>1>1>2>2asdasd
            // Step 2 => creating property for the bombs 
            int bomb = 0;
            // Step 3 => looping throughout the textField searching for bomb
            for (int i = 0; i < textField.Length; i++)
            {
                //Step 4 checkoing ifg bomb is more then 0 and the currentIndex of the textFierld is deffernt then > 
                if (bomb > 0 && textField[i] != '>')
                {
                    textField = textField.Remove(i, 1);
                    bomb--;
                    i--;
                }
                //Step 4.1 if the index the current char == > then we have explosion and then we have add the power of that explosion which we can find on the next index
                else if (textField[i] == '>')
                {
                    bomb += int.Parse(textField[i + 1].ToString());
                }
            }
            Console.WriteLine(textField);

        }
    }
}