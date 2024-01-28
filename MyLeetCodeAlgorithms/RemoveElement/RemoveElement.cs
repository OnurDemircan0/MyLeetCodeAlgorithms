﻿/* INSTRUCTIONS

Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
*/

/* Constraints:

0 <= nums.length <= 100
0 <= nums[i] <= 50
0 <= val <= 100
*/

int[] nums = { 3, 2, 2, 3, 4 };
int val = 3;

int RemoveElement(int[] nums, int val)
{
    Array.Sort(nums);

    int k = nums.Length;

    for(int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val)
        {
            k--;
            nums[i] = nums[k];
        }
    }

    return k;
}

RemoveElement(nums, val);