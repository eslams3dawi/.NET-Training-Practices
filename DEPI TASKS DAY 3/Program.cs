namespace DEPI_TASKS_DAY_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ReverseMethod
            //    Console.Write("Enter the text or number to reverse it : ");
            //    var BeforeReversed = Console.ReadLine();
            //    Console.WriteLine(Reverse(BeforeReversed));
            //}

            //static string Reverse(string BeforeReversed)
            //{
            //    string AfterReversed = "";
            //    for(int Index = BeforeReversed.Length - 1; Index >=0; Index--)
            //    {
            //        AfterReversed += BeforeReversed[Index];
            //    }
            //    return AfterReversed; 
            #endregion



            #region CountVowelsMethod
            //    Console.Write("I'm here to count all vowels in your text, just provide me the text here : ");
            //    var TextInput = Console.ReadLine();
            //    Console.WriteLine(CountVowels(TextInput));
            //}
            //static int CountVowels(string TextInput)
            //{
            //    char[] Vowels = { 'a', 'i', 'o', 'u', 'e' };
            //    int CountOfVowels = 0;
            //    for(int I = 0; I < TextInput.Length; I++)
            //    {
            //        for(int J = 0; J < Vowels.Length; J++)
            //        {
            //            if (TextInput[I] == Vowels[J])
            //            {
            //                CountOfVowels++;
            //            }
            //        }
            //    }
            //    return CountOfVowels; 
            #endregion



            #region Palindrome
            //    Console.Write("Enter the text/number : ");
            //    var Input = Console.ReadLine();
            //    Console.WriteLine(IsPalindrome(Input));
            //}

            //static bool IsPalindrome(string input)
            //{
            //    bool check = true;
            //    for(int Index = 0; Index < input.Length/2; Index++)
            //    {
            //        if (input[Index] != input[input.Length - 1 - Index])
            //        {
            //            check = false;
            //            break;
            //        }
            //    }
            //    return check;
            //} 
            #endregion



            #region MinMethod
            //    Console.Write("How many numbers in your array ? : ");
            //    var Input = Console.ReadLine();
            //    int SizeArray;
            //    if (int.TryParse(Input, out SizeArray))
            //        SizeArray = int.Parse(Input);
            //    else
            //    {
            //        Console.WriteLine("Invalid input");
            //        return;
            //    }
            //    int[] Numbers = new int[SizeArray];
            //    string input;
            //    Console.Write("Enter the numbers : ");
            //    for (int Index = 0; Index < SizeArray; Index++)
            //    {
            //        input = Console.ReadLine();
            //        Numbers[Index] = int.Parse(input);
            //    }

            //    Console.WriteLine($"The smallest number in your array is [{FindMinimum(Numbers)}]");
            //}

            //static int FindMinimum(int[] numbers)
            //{
            //    int MinValue = numbers[0];
            //    for (int Index = 0; Index < numbers.Length; Index++)
            //    {
            //        if (numbers[Index] <= MinValue)
            //            MinValue = numbers[Index];
            //    }
            //    return MinValue;
            //} 
            #endregion
        }
    }
}
