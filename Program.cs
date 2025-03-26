namespace loop_Brown_Jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //asks for an answer and saves it as answer
            Console.WriteLine("What is the boss boss fight in gaming and why?");
            string answer = Console.ReadLine();
            // tells the user the number of space in there is answer useing the countNumberOfSpaces methed
            Console.WriteLine($"the answer for who is the best boss \"{answer}\" has {CountNumberOfSpaces(answer)} spaces in it");
            //asks for an answer using numbers and saves it as answer
            Console.WriteLine("type a number");
            string numberAnswer = Console.ReadLine();
            // tells the user the sum of the digits useing the sumOfDigit methed
            Console.WriteLine($"The sum of the digits of {numberAnswer} is {SumOfDights(numberAnswer)}");
        }
        //makes the CountNumberOfSpaces method
        static int CountNumberOfSpaces(string sentence)
        {
            //keeps track of spaces
            int numberOfSpaces = 0;
            //repets chacking evrey chactor for spaces
            foreach (char character in sentence)
            {   // if the chactor is a space  it adds one to numberOfSpace
                if (character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }

        //makes the sumOfDights method
        static int SumOfDights(string number)
        {    //keeps track of sum
            int sum = 0;
            //repats and checks every dight used
            foreach (char digit in number)
            {
                //adds the dights 
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
