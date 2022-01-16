using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string command = Console.ReadLine();
            //int counter = 0;
            //while (command != "End")
            //{
            //    int target = int.Parse(command);

            //    for (int i = 0; i < sequenceOfTargets.Count; i++)
            //    {
            //        if (i == target)
            //        {


            //            for (int j = 0; j < sequenceOfTargets.Count; j++)
            //            {
            //                if (sequenceOfTargets[i] > sequenceOfTargets[j])
            //                {
            //                    sequenceOfTargets[j] -= sequenceOfTargets[i];
            //                }
            //                else if (sequenceOfTargets[i] < sequenceOfTargets[j])
            //                {
            //                    sequenceOfTargets[j] += sequenceOfTargets[i];
            //                }
            //            }

            //            if (sequenceOfTargets[i] == -1)
            //            {
            //                break;
            //            }
            //            sequenceOfTargets[i] = -1;
            //            counter++;
            //        }
            //    }
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", sequenceOfTargets)}");
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = "";

            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {

                int indexTarget = int.Parse(command);

                if (indexTarget >= 0 && indexTarget < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int temp = targets[indexTarget];

                        if (targets[i] != -1 && i != indexTarget)
                        {
                            if (targets[i] > temp)
                            {
                                targets[i] -= temp;
                            }
                            else if (targets[i] <= temp)
                            {
                                targets[i] += temp;

                            }
                        }
                    }
                    targets[indexTarget] = -1;
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', targets));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string command = Console.ReadLine();
            //int counter = 0;
            //while (command != "End")
            //{
            //    int target = int.Parse(command);

            //    for (int i = 0; i < sequenceOfTargets.Count; i++)
            //    {
            //        if (i == target)
            //        {


            //            for (int j = 0; j < sequenceOfTargets.Count; j++)
            //            {
            //                if (sequenceOfTargets[i] > sequenceOfTargets[j])
            //                {
            //                    sequenceOfTargets[j] -= sequenceOfTargets[i];
            //                }
            //                else if (sequenceOfTargets[i] < sequenceOfTargets[j])
            //                {
            //                    sequenceOfTargets[j] += sequenceOfTargets[i];
            //                }
            //            }

            //            if (sequenceOfTargets[i] == -1)
            //            {
            //                break;
            //            }
            //            sequenceOfTargets[i] = -1;
            //            counter++;
            //        }
            //    }
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", sequenceOfTargets)}");
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = "";

            int counter = 0;

            while ((command = Console.ReadLine()) != "End")
            {

                int indexTarget = int.Parse(command);

                if (indexTarget >= 0 && indexTarget < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int temp = targets[indexTarget];

                        if (targets[i] != -1 && i != indexTarget)
                        {
                            if (targets[i] > temp)
                            {
                                targets[i] -= temp;
                            }
                            else if (targets[i] <= temp)
                            {
                                targets[i] += temp;

                            }
                        }
                    }
                    targets[indexTarget] = -1;
                    counter++;
                }
            }

            Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', targets));
        }
    }
}
