﻿using System;
using System.Collections.Generic;

namespace Easy
{
    public class TwoSumExercises
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map.Add(nums[i], i);
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
