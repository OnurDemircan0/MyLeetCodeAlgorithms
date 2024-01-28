/* INSTRUCTIONS

Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
Return k.
*/

/* Constraints:

1 <= nums.length <= 3 * 104
-100 <= nums[i] <= 100
nums is sorted in non-decreasing order.
*/

int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 1) return 1;

    int k = nums.Length;
    int currentNumber = nums[0];

    for(int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == currentNumber)
        {
            nums[i] = int.MaxValue;
            k--;
        }
        else currentNumber = nums[i];
    }

    Array.Sort(nums);

    return k;
}

RemoveDuplicates(nums);