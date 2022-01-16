using System;
using System.Collections.Generic;
using System.Linq;

namespace LabT03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
			List<int> merged = new List<int>();

			if (nums.Count >= nums2.Count)
			{
				for (int i = 0; i < nums.Count; i++)
				{
					merged.Add(nums[i]);
					if (i < nums2.Count)
					{
						merged.Add(nums2[i]);
					}
				}
			}
			else
			{
				for (int i = 0; i < nums2.Count; i++)
				{
					if (i < nums.Count)
					{
						merged.Add(nums[i]);
					}
					merged.Add(nums2[i]);
				}
			}
			Console.WriteLine(string.Join(" ", merged));
		}
    }
}
