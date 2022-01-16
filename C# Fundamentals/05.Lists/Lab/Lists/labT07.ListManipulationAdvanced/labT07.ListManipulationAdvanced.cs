//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace labT07.ListManipulationAdvanced
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> MyList = Console.ReadLine().Split().Select(int.Parse).ToList();
//            List<int> MyList2 = MyList;
//            string command = Console.ReadLine();
//            while (command != "end")
//            {
//                string[] tokens = command.Split();

//                switch (tokens[0])
//                {
//                    case "Contains":
//                        int numberContains = int.Parse(tokens[1]);
//                        MyList.Contains(numberContains);

//                        if (MyList.Contains(numberContains))
//                        {
//                            Console.WriteLine("Yes");
//                        }

//                        else
//                        {
//                            Console.WriteLine("No such number");
//                        }
//                        break;
//                    case "PrintEven":
//                        for (int i = 0; i < MyList.Count; i++)
//                        {
//                            if (MyList[i] % 2 == 0)
//                            {
//                                Console.Write($"{MyList[i]} ");
//                            }
//                        }
//                        Console.WriteLine();
//                        break;
//                    case "PrintOdd":
//                        for (int i = 0; i < MyList.Count; i++)
//                        {
//                            if (MyList[i] % 2 == 0)
//                            {
//                                continue;
//                            }
//                            Console.Write($"{MyList[i]} ");
//                        }
//                        Console.WriteLine();
//                        break;
//                    case "GetSum":
//                        int sum = 0;
//                        for (int i = 0; i < MyList.Count; i++)
//                        {
//                            sum += MyList[i];
//                        }
//                        Console.WriteLine(sum);
//                        break;
//                    case "Filter":
//                        string condition = tokens[1];
//                        int number = int.Parse(tokens[2]);
//                        for (int i = 0; i < MyList.Count; i++)
//                        {
//                            switch (condition)
//                            {
//                                case "<":
//                                    if (MyList[i] < number)
//                                    {
//                                        Console.Write($"{MyList[i]} ");
//                                    }
//                                    Console.WriteLine();
//                                    break;
//                                case ">":
//                                    if (MyList[i] > number)
//                                    {
//                                        Console.Write($"{MyList[i]} ");
//                                    }
//                                    Console.WriteLine();
//                                    break;
//                                case ">=":
//                                    if (MyList[i] >= number)
//                                    {
//                                        Console.Write($"{MyList[i]} ");
//                                    }
//                                    Console.WriteLine();
//                                    break;
//                                case "<=":
//                                    if (MyList[i] <= number)
//                                    {
//                                        Console.Write($"{MyList[i]} ");
//                                    }
//                                    Console.WriteLine();
//                                    break;
//                            }
//                        }
//                        break;
//                    case "Add":
//                        int numberToAdd = int.Parse(tokens[1]);
//                        MyList2.Add(numberToAdd);
//                        break;
//                    case "Remove":
//                        int numberToRemove = int.Parse(tokens[1]);
//                        MyList2.Remove(numberToRemove);
//                        break;
//                    case "RemoveAt":
//                        int indexToRemove = int.Parse(tokens[1]);
//                        MyList2.RemoveAt(indexToRemove);
//                        break;
//                    case "Insert":
//                        int numberToInsert = int.Parse(tokens[1]);
//                        int indexToAddAt = int.Parse(tokens[2]);
//                        MyList2.Insert(indexToAddAt, numberToInsert);
//                        break;
//                }

//                command = Console.ReadLine();
//            }
//            if (MyList != MyList2)
//            {
//                Console.WriteLine(string.Join(" ", MyList2));
//            }
//            else
//            {
//                return;    
//            }

//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> evenNums = new List<int>();
            List<int> oddNums = new List<int>();
            List<int> filterSmall = new List<int>();
            List<int> filterESmall = new List<int>();
            List<int> filterBig = new List<int>();
            List<int> filterEBig = new List<int>();

            string command = string.Empty;
            string condition = string.Empty;
            int numberContains = 0;
            int sum = 0;
            int numberFilter = 0;
            int count = 0;

            while (command != "end")
            {
                command = Console.ReadLine().ToLower();
                string[] parts = command.Split();

                if (parts[0] == "add")
                {
                    int numberToAdd = int.Parse(parts[1]);
                    numbers.Add(numberToAdd);
                }

                if (parts[0] == "remove")
                {
                    int numberToRemove = int.Parse(parts[1]);
                    numbers.Remove(numberToRemove);
                }

                if (parts[0] == "removeat")
                {
                    int numberToRemoveAt = int.Parse(parts[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }

                if (parts[0] == "insert")
                {
                    int numberToInsert = int.Parse(parts[1]);
                    int indexToInsert = int.Parse(parts[2]);

                    numbers.Insert(indexToInsert, numberToInsert);
                }


                if (parts[0] == "add" || parts[0] == "remove" || parts[0] == "removeat"
                       || parts[0] == "insert")
                {
                    count++;
                }

                if (parts[0] == "contains")
                {
                    numberContains = int.Parse(parts[1]);
                    numbers.Contains(numberContains);

                    if (numbers.Contains(numberContains))
                    {
                        Console.WriteLine("Yes");
                    }

                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }

                if (parts[0] == "printeven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            evenNums.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", evenNums));
                }

                if (parts[0] == "printodd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 1)
                        {
                            oddNums.Add(numbers[i]);
                        }
                    }

                    Console.WriteLine(string.Join(" ", oddNums));
                }

                if (parts[0] == "getsum")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];

                    }

                    Console.WriteLine(sum);
                }

                if (parts[0] == "filter")
                {
                    condition = parts[1];
                    numberFilter = int.Parse(parts[2]);

                    if (condition == "<")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < numberFilter)
                            {
                                filterSmall.Add(numbers[i]);

                            }
                        }

                        Console.WriteLine(string.Join(" ", filterSmall));

                    }
                    else if (condition == ">")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > numberFilter)
                            {
                                filterBig.Add(numbers[i]);

                            }
                        }

                        Console.WriteLine(string.Join(" ", filterBig));

                    }
                    else if (condition == ">=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] >= numberFilter)
                            {
                                filterEBig.Add(numbers[i]);

                            }
                        }

                        Console.WriteLine(string.Join(" ", filterEBig));

                    }

                    else if (condition == "<=")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= numberFilter)
                            {
                                filterESmall.Add(numbers[i]);

                            }
                        }

                        Console.WriteLine(string.Join(" ", filterESmall));

                    }
                }
            }

            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
