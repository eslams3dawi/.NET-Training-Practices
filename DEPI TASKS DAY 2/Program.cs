using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace DEPI_TASKS_DAY_2
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("[1] Add");
            Console.WriteLine("[2] Substract");
            Console.WriteLine("[3] Multiple");
            Console.WriteLine("[4] Divide");
            Console.WriteLine("[5] Modules\n");
            Console.WriteLine("[6] Exit");
        }

        static void Main()
        {
            while (true)
            {
                Console.Write($"Enter Number One : ");
                int NumberOne = int.Parse(Console.ReadLine());

                Console.Write($"Enter Number Two : ");
                int NumberTwo = int.Parse(Console.ReadLine());
                int Choice = 0;
                Menu();
                Console.Write("Choose an operation : ");
                var Input = Console.ReadLine();
                if (int.TryParse(Input, out Choice))
                    Choice = int.Parse(Input);
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");
                        break;
                    case 2:
                        Console.WriteLine($"{NumberOne} - {NumberTwo} = {NumberOne - NumberTwo}");
                        break;
                    case 3:
                        Console.WriteLine($"{NumberOne} * {NumberTwo} = {NumberOne * NumberTwo}");
                        break;
                    case 4:
                        Console.WriteLine($"{NumberOne} / {NumberTwo} = {NumberOne / NumberTwo}");
                        break;
                    case 5:
                        Console.WriteLine($"{NumberOne} % {NumberTwo} = {NumberOne % NumberTwo}");
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}






#region Switch_TaskDay2
//enum DaysOfWeek
//{
//    None = 0,
//    Sunday = 1,
//    Monday = 2,
//    Tuesday = 3,
//    Wednesday = 4,
//    Thursday = 5,
//    Friday = 6,
//    Saturday = 7,
//}

//static void Main(string[] args)
//{
//    Console.Write("Enter the number of the day : ");
//    var Input = Console.ReadLine();
//    int DayOfTheWeek;
//    if (int.TryParse(Input, out DayOfTheWeek))
//        DayOfTheWeek = int.Parse(Input);
//    else
//        Console.WriteLine("Invalid Input");

//    switch (DayOfTheWeek)
//    {
//        case 1:
//            Console.WriteLine(DaysOfWeek.Sunday);
//            break;
//        case 2:
//            Console.WriteLine(DaysOfWeek.Monday);
//            break;
//        case 3:
//            Console.WriteLine(DaysOfWeek.Tuesday);
//            break;
//        case 4:
//            Console.WriteLine(DaysOfWeek.Wednesday);
//            break;
//        case 5:
//            Console.WriteLine(DaysOfWeek.Thursday);
//            break;
//        case 6:
//            Console.WriteLine(DaysOfWeek.Friday);
//            break;
//        case 7:
//            Console.WriteLine(DaysOfWeek.Saturday);
//            break;

//        default:
//            Console.WriteLine("Invalid option");
//            break;
//    }

#endregion







#region Mul-table_TaksDay2
//for(int OperandOne = 1; OperandOne <= 12; OperandOne++)
//{
//    for(int OperandTwo = 1; OperandTwo <= 12; OperandTwo++)
//    {
//        Console.WriteLine($"{OperandOne} * {OperandTwo} = {OperandOne * OperandTwo}");
//    }
//} 
#endregion







#region DoWhile_TaskDay2
//    int Number;
//do
//{
//    Console.Write("Enter number greater than 10 : ");
//    var Input = Console.ReadLine();
//    if (int.TryParse(Input, out Number))
//    {
//        Number = int.Parse(Input);
//    }
//    else
//    {
//        Console.WriteLine("Invalid input");
//        return;
//    }
//}
//while (Number <= 10); 
#endregion








#region CountEvenTaskDay2
//static void Main()
//{
//    Console.Write("Enter the size of your array : ");
//    var Input = Console.ReadLine();
//    int Size, Summation = 0;
//    if (int.TryParse(Input, out Size))
//        Size = int.Parse(Input);
//    else
//        Console.WriteLine("Invalid input");
//    int[] Numbers = new int[Size];
//    for(int Index = 0; Index < Size; Index++)
//    {
//        Console.WriteLine($"Index {Index}");
//        Numbers[Index] = int.Parse(Console.ReadLine());
//    }
//    foreach(var Number in Numbers)
//    {
//        if (Number % 2 == 0)
//            Summation += Number;
//    }
//    Console.Write($"The summation of even numbers in your array : {Summation}");
//} 
#endregion










#region ReverseArrayTaskDay2
//Console.Write("Enter the elements : ");
//var Elements = Console.ReadLine();
//var ReversedElements = "";
//for(int Index = Elements.Length-1; Index >= 0; Index--)
//{
//    ReversedElements += Elements[Index];
//}
//Console.Write($"The array in reversed way : {ReversedElements}"); 
#endregion